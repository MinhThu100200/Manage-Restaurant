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
    public partial class ListBillForm : Form
    {
        public ListBillForm()
        {
            InitializeComponent();
        }

        private void ListBillForm_Load(object sender, EventArgs e)
        {
            dataGridViewListBill.ReadOnly = true;
            dataGridViewListBill.AllowUserToAddRows = false;
            dataGridViewListBill.RowTemplate.Height = 80;
            dataGridViewListBill.DataSource = BillDAO.Instance.GetBillByToday();

        }

        private void dateTimePickerForm_ValueChanged(object sender, EventArgs e)
        {
            string datefrom = dateTimePickerForm.Value.ToString();
            string dateto = dateTimePickerTo.Value.ToString();

            dataGridViewListBill.DataSource = BillDAO.Instance.GetBillByBetween(datefrom, dateto);
        }

        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            string datefrom = dateTimePickerForm.Value.ToString();
            string dateto = dateTimePickerTo.Value.ToString();

            dataGridViewListBill.DataSource = BillDAO.Instance.GetBillByBetween(datefrom, dateto);
        }
    }
}
