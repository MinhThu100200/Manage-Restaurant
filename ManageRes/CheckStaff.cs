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
    public partial class CheckStaff : Form
    {
        public CheckStaff()
        {
            InitializeComponent();
        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(CheckInDAO.Instance.InsertCheckIn(DateTime.Now, Globals.Users.Id))
            {
                MessageBox.Show("Success!!!", "Check In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkInToolStripMenuItem.Enabled = false;
            }  
            else
            {
                MessageBox.Show("Error!!!", "Check In", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckOutDAO.Instance.InsertCheckOut(DateTime.Now, Globals.Users.Id))
            {
                MessageBox.Show("Success!!!", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkOutToolStripMenuItem.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error!!!", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }     

        private void CheckStaff_Load(object sender, EventArgs e)
        {
            TimeSpan startTime = TimeSpan.Parse("22:05");
            //TimeSpan endTime = TimeSpan.Parse("00:00");
            //DateTime date = new DateTime(2021, 6, 4, 22, 5, 00);
            if(DateTime.Now.TimeOfDay > startTime)
            {
                salaryToolStripMenuItem1.Enabled = true;
            }    
        }

        private void salaryToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Schedule frm = new Schedule();
            frm.ShowDialog();
        }
    }
}
