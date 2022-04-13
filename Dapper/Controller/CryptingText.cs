using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Controller
{
    class CryptingText
    {
        public string Generate(string pass)
        {
            return BCrypt.Net.BCrypt.HashPassword(pass);
        }
    }
}
