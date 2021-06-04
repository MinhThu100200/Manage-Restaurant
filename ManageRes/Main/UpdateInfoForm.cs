using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageRes
{
    public partial class UpdateInfoForm : Form
    {
        public UpdateInfoForm()
        {
            InitializeComponent();
        }

        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if(Globals.Users.Role == 1)
            {
                this.Hide();
                MainForm frm = new MainForm();
                frm.ShowDialog();
            }    
            else
            {
                this.Hide();
                CheckStaff frm = new CheckStaff();
                frm.ShowDialog();
            }    
            
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int idnhanvien = Globals.Users.Id;
                string fullname = textBoxFullname.Text;
                string address = richTextBoxAddress.Text;
                DateTime birthday = dateTimePickerBirthday.Value.Date;
                MemoryStream pic = new MemoryStream();

                //check age
                int bornYear = birthday.Year;
                int nowYear = DateTime.Now.Year;
                if (nowYear - bornYear < 16 || nowYear - bornYear > 50)
                {
                    MessageBox.Show("The student age must be between 16 and 45 year", "Invalid Birthday", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (verify())
                {
                    pictureBoxImage.Image.Save(pic, pictureBoxImage.Image.RawFormat);
                    if (UserInfoDAO.Instance.InsertUserInfo(idnhanvien, fullname, address, birthday, pic))
                    {
                        MessageBox.Show("Success!!!", "Update Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (Globals.Users.Role == 1)
                        {
                            this.Hide();
                            MainForm frm = new MainForm();
                            frm.ShowDialog();
                        }
                        else
                        {
                            this.Hide();
                            CheckStaff frm = new CheckStaff();
                            frm.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error", "Update Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You must fill in all of them", "Update Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }
        bool verify()
        {
            if(textBoxFullname.Text.Trim() != "" && richTextBoxAddress.Text.Trim() != "")
            {
                return true;
            }
            return false;
        }
    }
}
