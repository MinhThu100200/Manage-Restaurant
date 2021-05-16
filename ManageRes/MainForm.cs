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
            if (panelBan.Visible == true)
                panelBan.Visible = false;
            //if (panelCourse.Visible == true)
            //    panelCourse.Visible = false;
            //if (panelScore.Visible == true)
            //    panelScore.Visible = false;
            //if (panelResult.Visible == true)
            //    panelResult.Visible = false;
        }
        private void customerDesign()
        {
            panelBan.Visible = false;
            //panelCourse.Visible = false;
            //panelScore.Visible = false;
            //panelResult.Visible = false;
        }
        #region Button Click




        #endregion

        private void buttonBan_Click(object sender, EventArgs e)
        {
            showPanel(panelBan);
        }
    }
}
