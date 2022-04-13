using Dapper.Controller;
using System;
using System.Windows.Forms;

namespace Dapper
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            SignInbutton.Click += SignInbutton_Click;
            PasstextBox.TextChanged += PasstextBox_TextChanged;
        }


        private void SignInbutton_Click(object sender, EventArgs e)
        {
            RegistrationController user = new RegistrationController();
            user.Regestration(MailtextBox.Text, PasstextBox.Text);
        }
        private void PasstextBox_TextChanged(object sender, EventArgs e)
        {
            if (PasstextBox.Text == "")
            {
                SignInbutton.Enabled = false;
            }
            else
            {
                SignInbutton.Enabled = true;
            }
        }
    }
}
