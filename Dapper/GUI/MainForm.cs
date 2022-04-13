using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dapper.GUI
{
    public partial class MainForm : Form
    {
        SignUp signUp;
        SIgnIn sIgnIn;
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            SignInbutton.Click += SignIn;
            SignUpbutton.Click += SignUp;
        }

        private void SignUp(object sender, EventArgs e) 
        {
            signUp = new SignUp();
            signUp.Show();
        }

        private void SignIn(object sender, EventArgs e) 
        {
            sIgnIn = new SIgnIn();
            sIgnIn.Show(); 
        }

    }
}