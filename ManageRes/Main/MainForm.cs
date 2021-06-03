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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            customerDesign();
        }
        public Form activeForm = null;
        public void openchildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void showPanel(Panel menu)
        {
            if (menu.Visible == false)
            {
                hideAllPanel();
                menu.Visible = true;
            }
            else
            {
                menu.Visible = false;
            }
        }
        private void hideAllPanel()
        {
            if (panelMonAn.Visible == true)
                panelMonAn.Visible = false;
            if (panelBan.Visible == true)
                panelBan.Visible = false;
            if (panelKhoHang.Visible == true)
                panelKhoHang.Visible = false;
            if (panelKhachHang.Visible == true)
                panelKhachHang.Visible = false;
            if (panelTaiKhoan.Visible == true)
                panelTaiKhoan.Visible = false;
        }
        private void customerDesign()
        {
            panelMonAn.Visible = false;
            panelBan.Visible = false;
            panelKhachHang.Visible = false;
            panelKhoHang.Visible = false;
            panelTaiKhoan.Visible = false;
        }
        #region Button Click




        #endregion

        private void buttonBan_Click(object sender, EventArgs e)
        {
            showPanel(panelBan);
        }

        private void buttonMon_Click(object sender, EventArgs e)
        {
            showPanel(panelMonAn);
        }

        private void buttonKhachHang_Click(object sender, EventArgs e)
        {
            showPanel(panelKhachHang);
        }

        private void buttonKho_Click(object sender, EventArgs e)
        {
            showPanel(panelKhoHang);
        }

        private void buttonTaiKhoan_Click(object sender, EventArgs e)
        {
            showPanel(panelTaiKhoan);
        }

        private void buttonVeToi_Click(object sender, EventArgs e)
        {
            AboutMe frm = new AboutMe();
            frm.ShowDialog();
        }

        private void buttonDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm frm = new LoginForm();
            frm.ShowDialog();
        }

        private void buttonXoaHang_Click(object sender, EventArgs e)
        {

        }

        private void buttonDSMon_Click(object sender, EventArgs e)
        {
            openchildForm(new ListFoodForm());
        }       
        private void buttonBestSeller_Click(object sender, EventArgs e)
        {
            openchildForm(new BestSellerForm());
        }

        private void buttonThemBan_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                int id = Globals.Users.Id;
                if (UserInfoDAO.Instance.GetUserInfoByID(id).Rows[0]["HinhAnh"] != null)
                {
                    byte[] pic = (byte[])UserInfoDAO.Instance.GetUserInfoByID(id).Rows[0]["HinhAnh"];
                    MemoryStream picture = new MemoryStream(pic);
                    pictureBoxImage.Image = Image.FromStream(picture);
                    
                }
                if (Globals.Users.Role == 1)
                {
                    labelPosition.Text = "Xin chào Quản lý";
                }
                else
                {
                    labelPosition.Text = "Xin chào";
                }

            }
            catch { }
           
            
        }

        private void buttonCRUDTable_Click(object sender, EventArgs e)
        {
            openchildForm(new CRUDTableForm());
        }

        private void buttonBookFood_Click(object sender, EventArgs e)
        {
            openchildForm(new BookFoodForm());
        }

        private void buttonListFood_Click(object sender, EventArgs e)
        {
            openchildForm(new WareHouseForm());
        }

        private void buttonDanhSachKhach_Click(object sender, EventArgs e)
        {
            openchildForm(new ListCustomerForm());
        }

        private void buttonListBill_Click(object sender, EventArgs e)
        {
            openchildForm(new ListBillForm());
        }
    }
}
