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
        DataTable newTable = new DataTable();
        private void ChooseFood_Load(object sender, EventArgs e)
        {

            //price table
            DataTable dt = TypeTableDAO.Instance.GetTypeByID(GlobalsTable.tables.Loai);
            textBoxPriceTable.Text = dt.Rows[0][2].ToString();

            //combobox
            comboBoxFood.DataSource = FoodDAO.Instance.GetAllFoodExist();
            comboBoxFood.DisplayMember = "Ten";
            comboBoxFood.ValueMember = "Id";
            //comboBoxFood.SelectedItem = null;

            newTable.Columns.Add("ID Mon", typeof(System.Int32));
            newTable.Columns.Add("Ten Mon", typeof(System.String));
            newTable.Columns.Add("So Luong", typeof(System.Int32));
            newTable.Columns.Add("Gia", typeof(System.Double));

            dataGridViewListFood.AllowUserToAddRows = false;
            dataGridViewListFood.ReadOnly = true;
            dataGridViewListFood.RowTemplate.Height = 80;
        }

        private void comboBoxFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = (int)comboBoxFood.SelectedValue;
                DataTable dt = FoodDAO.Instance.GetFoodByID(id);

                textBoxPriceFood.Text = dt.Rows[0][2].ToString();
            }
            catch
            {

            }


        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //DataTable newTable = new DataTable();
            int id = (int)comboBoxFood.SelectedValue;
            string name = comboBoxFood.Text;
            int amount =(int) numericUpDownAmountFood.Value;
            double price = Convert.ToDouble(textBoxPriceFood.Text);
            int dem = 0;
            for(int i = 0; i < newTable.Rows.Count; i++)
            {
                if (newTable.Rows[i][1].ToString() == name)
                {
                    newTable.Rows[i][2] = Convert.ToInt32(newTable.Rows[i][2]) + amount;
                    break;
                }   
                else
                {
                    dem++;
                }    
            }  
            
            if(dem == newTable.Rows.Count)
            {
                newTable.Rows.Add(id, name, amount, price);
            }    
            

            dataGridViewListFood.DataSource = newTable;
        }

        private void dataGridViewListFood_DoubleClick(object sender, EventArgs e)
        {
            comboBoxFood.SelectedItem = dataGridViewListFood.CurrentRow.Cells[0].Value;
            textBoxPriceFood.Text = dataGridViewListFood.CurrentRow.Cells[3].Value.ToString();
            numericUpDownAmountFood.Value = (int)dataGridViewListFood.CurrentRow.Cells[2].Value;
           
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int id = (int)comboBoxFood.SelectedValue;
            string name = comboBoxFood.Text;
            int amount = (int)numericUpDownAmountFood.Value;
            double price = Convert.ToDouble(textBoxPriceFood.Text);
            int dem = 0;
           
            for(int i = 0; i <newTable.Rows.Count; i++)
            {
                if(name == dataGridViewListFood.CurrentRow.Cells[1].Value.ToString() && name == newTable.Rows[i][1].ToString())
                {
                    newTable.Rows[i][2] = amount;
                        
                } 
                else if(name != dataGridViewListFood.CurrentRow.Cells[1].Value.ToString() && 
                    dataGridViewListFood.CurrentRow.Cells[1].Value.ToString() == newTable.Rows[i][1].ToString())
                {
                    for(int j = 0; j < dataGridViewListFood.Rows.Count; j++)
                    {
                        if (name == newTable.Rows[j][1].ToString())
                        {
                            newTable.Rows[j][2] = Convert.ToInt32(newTable.Rows[j][2]) + amount;
                            newTable.Rows[j].Delete();
                            break;
                        }
                        else
                        {
                            dem++;
                        }
                    }    
                    if(dem == dataGridViewListFood.Rows.Count)
                    {
                        newTable.Rows[i][0] = id;
                        newTable.Rows[i][1] = name;
                        newTable.Rows[i][2] = amount;
                        newTable.Rows[i][3] = price;
                    }    
                    
                }    
            }    



            dataGridViewListFood.DataSource = newTable;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < dataGridViewListFood.Rows.Count; i++)
            {
                if(newTable.Rows[i][1].ToString() == dataGridViewListFood.CurrentRow.Cells[1].Value.ToString())
                {
                    newTable.Rows[i].Delete();
                }    
            }
            dataGridViewListFood.DataSource = newTable;
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < dataGridViewListFood.Rows.Count; i++)
            {

            }    
        }
    }
}
