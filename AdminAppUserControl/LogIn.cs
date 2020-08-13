using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminAppUserControl
{
    public partial class LogIn : UserControl
    {
        public string email, password;
        public LogIn()
        {
            InitializeComponent();
        }

        private void txtEmailEnter(object sender, EventArgs e)
        {
            if (txtEmail.Text.Equals("Email"))
            {
                txtEmail.Text = "";
            }
        }

        private void txtEmailLeave(object sender, EventArgs e)
        {
            if (txtEmail.Text.Equals(""))
            {
                txtEmail.Text = "Email";
            }
        }

        private void txtPassEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("Password"))
            {
                txtPassword.Text = "";
            }
        }

        private void txtPassLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.Text = "Password";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email" || txtPassword.Text == "Password")
            {
                DialogResult res = MessageBox.Show("Please Enter a Valid Email/Password!", "Invalid Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                getLogInformation(txtEmail.Text, txtPassword.Text);
                PostJob post = new PostJob();
                this.Hide();//because usercontrols have not Close() property as forms
                this.Parent.Controls.Add(post);

            }
        }

        public void getLogInformation(string em, string p)
        {
            email = em;
            password = p;
        }

        private void signUp1_Load(object sender, EventArgs e)
        {
            //signUp = new SignUp();
            //signUp.Show();
            //signUp.BringToFront();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            //signUp = new SignUp();
            //signUp.Hide();
            //signUp = new SignUp();
            //signUp.Show();
            //signUp.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignUp second = new SignUp();
            this.Hide();//because usercontrols have not Close() property as forms
            this.Parent.Controls.Add(second);
        }
    }
}
