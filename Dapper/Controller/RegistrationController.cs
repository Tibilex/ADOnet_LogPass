using Dapper.Models;
using System.Data.SqlClient;

namespace Dapper.Controller
{
    class RegistrationController
    {
        public RegistrationController()
        {

        }

        public void Regestration(string _email, string _pass)
        {
            string connectionString = @"Data Source=DESKTOP-440KLQF\SQLEXPRESS;Initial Catalog=RegistrationUser; Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Users regestration = new Users() { email = _email, password = new CryptingText().Generate(_pass) };
                connection.Execute("INSERT INTO Users (email, password) VALUES(@email,@password)", regestration);
            }
        }
    }
}
