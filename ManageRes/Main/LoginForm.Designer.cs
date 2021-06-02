
namespace ManageRes
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnSigUp = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.labelForgotPassword = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBoxShowPass = new System.Windows.Forms.CheckBox();
            this.radioButtonManager = new System.Windows.Forms.RadioButton();
            this.radioButtonStaff = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSignIn.Location = new System.Drawing.Point(29, 385);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(204, 34);
            this.btnSignIn.TabIndex = 17;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnSigUp
            // 
            this.btnSigUp.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSigUp.Location = new System.Drawing.Point(269, 385);
            this.btnSigUp.Name = "btnSigUp";
            this.btnSigUp.Size = new System.Drawing.Size(178, 34);
            this.btnSigUp.TabIndex = 16;
            this.btnSigUp.Text = "Sign Up";
            this.btnSigUp.UseVisualStyleBackColor = false;
            this.btnSigUp.Click += new System.EventHandler(this.btnSigUp_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(123, 292);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(324, 22);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.AutoCompleteCustomSource.AddRange(new string[] {
            "Nhập ký tự"});
            this.txtUsername.Location = new System.Drawing.Point(123, 245);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(324, 22);
            this.txtUsername.TabIndex = 14;
            // 
            // labelForgotPassword
            // 
            this.labelForgotPassword.AutoSize = true;
            this.labelForgotPassword.Location = new System.Drawing.Point(26, 344);
            this.labelForgotPassword.Name = "labelForgotPassword";
            this.labelForgotPassword.Size = new System.Drawing.Size(121, 17);
            this.labelForgotPassword.TabIndex = 12;
            this.labelForgotPassword.Text = "Forgot password?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "UserName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(60, 125);
            this.label1.MaximumSize = new System.Drawing.Size(500, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "Login To Your Account";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ManageRes.Properties.Resources.icon_login;
            this.pictureBox1.Location = new System.Drawing.Point(190, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // checkBoxShowPass
            // 
            this.checkBoxShowPass.AutoSize = true;
            this.checkBoxShowPass.Location = new System.Drawing.Point(314, 340);
            this.checkBoxShowPass.Name = "checkBoxShowPass";
            this.checkBoxShowPass.Size = new System.Drawing.Size(129, 21);
            this.checkBoxShowPass.TabIndex = 18;
            this.checkBoxShowPass.Text = "Show Password";
            this.checkBoxShowPass.UseVisualStyleBackColor = true;
            this.checkBoxShowPass.CheckedChanged += new System.EventHandler(this.checkBoxShowPass_CheckedChanged);
            // 
            // radioButtonManager
            // 
            this.radioButtonManager.AutoSize = true;
            this.radioButtonManager.Location = new System.Drawing.Point(29, 188);
            this.radioButtonManager.Name = "radioButtonManager";
            this.radioButtonManager.Size = new System.Drawing.Size(85, 21);
            this.radioButtonManager.TabIndex = 19;
            this.radioButtonManager.TabStop = true;
            this.radioButtonManager.Text = "Manager";
            this.radioButtonManager.UseVisualStyleBackColor = true;
            // 
            // radioButtonStaff
            // 
            this.radioButtonStaff.AutoSize = true;
            this.radioButtonStaff.Location = new System.Drawing.Point(385, 188);
            this.radioButtonStaff.Name = "radioButtonStaff";
            this.radioButtonStaff.Size = new System.Drawing.Size(58, 21);
            this.radioButtonStaff.TabIndex = 20;
            this.radioButtonStaff.TabStop = true;
            this.radioButtonStaff.Text = "Staff";
            this.radioButtonStaff.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 434);
            this.Controls.Add(this.radioButtonStaff);
            this.Controls.Add(this.radioButtonManager);
            this.Controls.Add(this.checkBoxShowPass);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.btnSigUp);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelForgotPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnSigUp;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label labelForgotPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxShowPass;
        private System.Windows.Forms.RadioButton radioButtonManager;
        private System.Windows.Forms.RadioButton radioButtonStaff;
    }
}

