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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            dataGridViewDoanhThu.ReadOnly = true;
            dataGridViewDoanhThu.AllowUserToAddRows = false;
            dataGridViewDoanhThu.RowTemplate.Height = 80;
            DataTable src = BillDetailDAO.Instance.GetTotalFoodOrderToday();
            dataGridViewDoanhThu.DataSource = src;
            dataGridViewDoanhThu.Columns[0].Width = 150;
            dataGridViewDoanhThu.Columns[1].Width = 200;
            dataGridViewDoanhThu.Columns[2].Width = 150;
        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            string datefrom = dateTimePickerFrom.Value.ToString();
            string dateto = dateTimePickerTo.Value.ToString();
            DataTable src = BillDetailDAO.Instance.GetTotalFoodOrderBetween(datefrom, dateto);
            dataGridViewDoanhThu.DataSource = src;
        }

        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            string datefrom = dateTimePickerFrom.Value.ToString();
            string dateto = dateTimePickerTo.Value.ToString();
            DataTable src = BillDetailDAO.Instance.GetTotalFoodOrderBetween(datefrom, dateto);
            dataGridViewDoanhThu.DataSource = src;
        }
    }
}
