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
    public partial class ChooseFood : Form
    {
        public ChooseFood()
        {
            InitializeComponent();
        }

        private void ChooseFood_Load(object sender, EventArgs e)
        {

            //price table
            DataTable dt = TypeTableDAO.Instance.GetTypeByID(GlobalsTable.tables.Loai);
            textBoxPriceTable.Text = dt.Rows[0][2].ToString();

            //combobox
            comboBoxFood.DataSource = FoodDAO.Instance.GetAllFood();
            comboBoxFood.DisplayMember = "Ten";
            comboBoxFood.ValueMember = "Id";
            comboBoxFood.SelectedItem = null;

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            ChooseFood_Load(null, null);
        }

        private void comboBoxFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)comboBoxFood.SelectedValue;
            DataTable dt = FoodDAO.Instance.GetFoodByID(id);

            textBoxPriceFood.Text = dt.Rows[0][2].ToString();


        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            DataTable newTable = new DataTable();

            newTable.Columns.Add("ID", typeof(System.Int32));
            newTable.Columns.Add("First name", typeof(System.String));
            newTable.Columns.Add("Last name", typeof(System.String));
        }
    }
}
