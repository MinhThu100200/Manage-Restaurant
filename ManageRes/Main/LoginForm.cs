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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        //signup
        private void btnSigUp_Click(object sender, EventArgs e)
        {
            SignUpForm frm = new SignUpForm();
            frm.ShowDialog();
        }
        //signin
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                DataRow dt;
                if (radioButtonManager.Checked)
                {
                    dt = UsersDAO.Instance.Login(username, password, 1);
                    Login(dt);
                }
                else if (radioButtonStaff.Checked)
                {
                    dt = UsersDAO.Instance.Login(username, password, 2);
                    Login(dt);
                }
                else
                {
                    MessageBox.Show("You must choose Manager or Staff", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Show();
                }
            }
            
            catch
            {

            }
         
        }
        //login
        public void Login(DataRow dt)
        {
            if (dt != null)
            {
                Users users = new Users(dt);
                Globals.Users = users;
                checkUserId(Globals.Users.Id);
                
            }
            else
            {
                if (txtUsername.Text == "")
                {
                    CreateControls();
                    MessageBox.Show("Invalid Username", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (txtPassword.Text == "")
                {
                    CreateControlsPass();
                    MessageBox.Show("Invalid Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Invalid Role, username or password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }

        }
        //check userid
        public void checkUserId(int id)
        {
            if (UserInfoDAO.Instance.GetUserInfoByIDUser(id).Rows.Count > 0)
            {
                this.Hide();
                MainForm frm = new MainForm();
                frm.ShowDialog();
            }
            else
            {
                this.Hide();
                UpdateInfoForm frm = new UpdateInfoForm();
                frm.ShowDialog();
            }
        }
        
        //showpass
        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }
        //load
        private void LoginForm_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 50;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;
            //dung set thay vi thao tac trong properties
            toolTip1.SetToolTip(this.txtUsername, "User name is not blank");
            toolTip1.SetToolTip(this.txtPassword, "Password is not blank");
        }
        //control
        void CreateControls()
        {
            ErrorProvider ep = new ErrorProvider();

            ep.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;


            ep.SetError(txtUsername, "Blank is not valid");
            this.Controls.Add(txtUsername);


        }
        void CreateControlsPass()
        {
            ErrorProvider ep = new ErrorProvider();

            ep.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;


            ep.SetError(txtPassword, "Blank is not valid");

            this.Controls.Add(txtPassword);


        }
    }
}
