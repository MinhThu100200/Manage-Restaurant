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
            dataGridViewListFood.AllowUserToAddRows = false;
            dataGridViewListFood.ReadOnly = true;
            dataGridViewListFood.RowTemplate.Height = 80;
            DataTable dt = TypeTableDAO.Instance.GetTypeByID(GlobalsTable.tables.Loai);
            if (GlobalsTable.tables.TinhTrang == 1)
            {
                dataGridViewListFood.DataSource = BillDetailDAO.Instance.GetBillDetailToPayment(GlobalsTable.tables.Id);
            }    
            else
            {
                newTable.Columns.Add("ID Mon", typeof(System.Int32));
                newTable.Columns.Add("Ten Mon", typeof(System.String));
                newTable.Columns.Add("So Luong", typeof(System.Int32));
                newTable.Columns.Add("Gia", typeof(System.Double));
            }    
            //price table
           
            textBoxPriceTable.Text = dt.Rows[0][2].ToString();

            //combobox
            comboBoxFood.DataSource = FoodDAO.Instance.GetAllFoodExist();
            comboBoxFood.DisplayMember = "Ten";
            comboBoxFood.ValueMember = "Id";
            //comboBoxFood.SelectedItem = null;
            
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
            int amount = (int)numericUpDownAmountFood.Value;
            DataTable dt = WarehouseDAO.Instance.GetAllWarehouse();

            if(amount>=1)
            {             
                //DataTable newTable = new DataTable();
                int id = (int)comboBoxFood.SelectedValue;
                string name = comboBoxFood.Text;
                int flag = 0;
                for(int j = 0; j < dt.Rows.Count; j++)
                {
                    if(dt.Rows[j][1].ToString() == name)
                    {
                        if(Convert.ToInt32(dt.Rows[j][2].ToString()) - amount >= 0)
                        {
                            flag = 1;
                            break;
                        }   
                        else
                        {
                            MessageBox.Show("Not enough", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }    
                        
                    }    
                }   
                if(flag == 1)
                {
                    double price = Convert.ToDouble(textBoxPriceFood.Text);
                    int dem = 0;
                    for (int i = 0; i < newTable.Rows.Count; i++)
                    {
                        if (newTable.Rows[i][1].ToString() == name)
                        {
                            for(int n = 0; n < dt.Rows.Count; n++)
                            {
                                if(dt.Rows[n][1].ToString() == name)
                                {
                                    if(Convert.ToInt32(dt.Rows[n][2].ToString()) - (Convert.ToInt32(newTable.Rows[i][2]) + amount) >= 0)
                                    {
                                        newTable.Rows[i][2] = Convert.ToInt32(newTable.Rows[i][2]) + amount;
                                        break;
                                    } 
                                    else
                                    {
                                        MessageBox.Show("Not enough", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        break;
                                    }    
                                }    
                            }    
                            
                            
                        }
                        else
                        {
                            dem++;
                        }
                    }

                    if (dem == newTable.Rows.Count)
                    {
                        newTable.Rows.Add(id, name, amount, price);
                    }
                    dataGridViewListFood.DataSource = newTable;
                }    
               
            }
            else
            {
                MessageBox.Show("Amount >= 1", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
        }

        private void dataGridViewListFood_DoubleClick(object sender, EventArgs e)
        {
            comboBoxFood.SelectedItem = dataGridViewListFood.CurrentRow.Cells[0].Value;
            textBoxPriceFood.Text = dataGridViewListFood.CurrentRow.Cells[3].Value.ToString();
            numericUpDownAmountFood.Value = (int)dataGridViewListFood.CurrentRow.Cells[2].Value;
           
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int amount = (int)numericUpDownAmountFood.Value;
            DataTable dt = WarehouseDAO.Instance.GetAllWarehouse();
            if (amount >= 1)
            {
                int id = (int)comboBoxFood.SelectedValue;
                string name = comboBoxFood.Text;
                int flag = 0;
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    if (dt.Rows[j][1].ToString() == name)
                    {
                        if (Convert.ToInt32(dt.Rows[j][2].ToString()) - amount >= 0)
                        {
                            flag = 1;
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Not enough", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }

                    }
                }
                if(flag == 1)
                {
                    double price = Convert.ToDouble(textBoxPriceFood.Text);
                    int dem = 0;

                    for (int i = 0; i < newTable.Rows.Count; i++)
                    {
                        if (name == dataGridViewListFood.CurrentRow.Cells[1].Value.ToString() && name == newTable.Rows[i][1].ToString())
                        {
                            newTable.Rows[i][2] = amount;

                        }
                        else if (name != dataGridViewListFood.CurrentRow.Cells[1].Value.ToString() &&
                            dataGridViewListFood.CurrentRow.Cells[1].Value.ToString() == newTable.Rows[i][1].ToString())
                        {
                            for (int j = 0; j < dataGridViewListFood.Rows.Count; j++)
                            {
                                if (name == newTable.Rows[j][1].ToString())
                                {
                                    for(int n = 0; n < dt.Rows.Count; n++)
                                    {
                                        if(name == dt.Rows[n][1].ToString())
                                        {
                                            if(Convert.ToInt32(dt.Rows[n][2].ToString()) - (Convert.ToInt32(newTable.Rows[j][2]) + amount) >= 0)
                                            {
                                                newTable.Rows[j][2] = Convert.ToInt32(newTable.Rows[j][2]) + amount;
                                                newTable.Rows[j].Delete();
                                                break;
                                            }  
                                            else
                                            {
                                                MessageBox.Show("Not enough", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                break;
                                            }    
                                        }    
                                    }    
                                    
                                }
                                else
                                {
                                    dem++;
                                }
                            }
                            if (dem == dataGridViewListFood.Rows.Count)
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
                else
                {
                    MessageBox.Show("Not enough", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }    
            }
            else
            {
                MessageBox.Show("Amount >= 1", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

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
            int dem = 0;
            DataTable dt = WarehouseDAO.Instance.GetAllWarehouse();
            for (int i = 0; i < dataGridViewListFood.Rows.Count; i++)
            {
                if(BillDetailDAO.Instance.InsertBillDetail(Convert.ToInt32(newTable.Rows[i][0].ToString()), Convert.ToInt32(newTable.Rows[i][2].ToString()), 
                    Convert.ToDouble(newTable.Rows[i][3].ToString()), GlobalsTable.tables.Id))
                {
                    
                    dem++;
                } 
                else
                {
                    MessageBox.Show("Error", "Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }    
            }   
            if(dem == dataGridViewListFood.Rows.Count)
            {
                
                
                if(TableDAO.Instance.UpdateStateByID(GlobalsTable.tables.Id, 1))
                {
                    //int flag = 0;
                    for(int i = 0; i < newTable.Rows.Count; i++)
                    {
                        for(int j = 0; j < dt.Rows.Count; j++)
                        {
                            if(dt.Rows[j][1].ToString() == newTable.Rows[i][1].ToString())
                            {
                                int soluong = Convert.ToInt32(dt.Rows[j][2].ToString()) - Convert.ToInt32(newTable.Rows[i][2].ToString());
                                WarehouseDAO.Instance.UpdateWarehouseOrder(dt.Rows[j][1].ToString(), soluong);                           
                            }    
                        }    
                    }
                    MessageBox.Show("Success!!!", "Order", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }    
            }    
        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {
            PaymentForm frm = new PaymentForm();
            frm.ShowDialog();
        }
    }
}
