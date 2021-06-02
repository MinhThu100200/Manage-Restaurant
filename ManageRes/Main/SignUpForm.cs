using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageRes
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }
        //signup
        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string confirm = textBoxConfirmPass.Text;
            string email = textBoxEmail.Text;
            string phone = textBoxPhone.Text;
            string role = textBoxRole.Text;
            int yourRole = 2;
            if (password == confirm && verify())
            {
                if(role == "Manager")
                {
                    yourRole = 1;
                    SignUp(username, password, email, phone, yourRole);

                }
                else if(role == "Accountant")
                {
                    yourRole = 3;
                    SignUp(username, password, email, phone, yourRole);
                }
                else if (role == "Staff")
                {                   
                    SignUp(username, password, email, phone, yourRole);
                }
            }
            else
            {
                MessageBox.Show("Password not the same or you not fill out all of them", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SignUp(string username, string password, string email, string phone, int role)
        {
            if(UsersDAO.Instance.InsertUser(username, password, email, phone, role))
            {
                MessageBox.Show("Success!!!", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Hide();

            }
            else
            {
                MessageBox.Show("Fail!!!", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        //verify
        bool verify()
        {
            if (textBoxUsername.Text.Trim() != "" && textBoxPassword.Text.Trim() != ""
                && textBoxPhone.Text.Trim() != "" && textBoxRole.Text.Trim() != ""
                && textBoxEmail.Text.Trim() != "")
            {
                return true;
            }
                
            return false;
        }

        //cancel
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxConfirmPass_TextChanged(object sender, EventArgs e)
        {
            string pass = textBoxPassword.Text.Trim();
            string confirm = textBoxConfirmPass.Text.Trim();
            ToolTip toolTip1 = new ToolTip();
            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 50;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;
            //dung set thay vi thao tac trong properties
            toolTip1.SetToolTip(this.textBoxConfirmPass, "Password is not same");
            
            if (pass == confirm)
            {
                toolTip1.SetToolTip(this.textBoxConfirmPass, "Password is same!!!!!!");
            }
        }
    }
}
