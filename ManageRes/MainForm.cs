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

        private void buttonXoa_Click(object sender, EventArgs e)
        {

        }

        private void buttonVeToi_Click(object sender, EventArgs e)
        {
            AboutMe frm = new AboutMe();
            frm.ShowDialog();
        }
    }
}
