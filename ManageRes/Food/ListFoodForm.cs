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
    public partial class ListFoodForm : Form
    {
        public ListFoodForm()
        {
            InitializeComponent();
        }

        private void ListFoodForm_Load(object sender, EventArgs e)
        {
            dataGridViewListFood.AllowUserToAddRows = false;
            dataGridViewListFood.ReadOnly = true;
            dataGridViewListFood.RowTemplate.Height = 80;
            DataTable dt = FoodDAO.Instance.GetAllFood();
            dataGridViewListFood.DataSource = dt;
            dataGridViewListFood.Columns[0].Width = 73;
            dataGridViewListFood.Columns[3].Width = 73;
        }

        private void buttonAddFood_Click(object sender, EventArgs e)
        {
            if(verify())
            {
                string name = textBoxNameFood.Text;
                double price = Convert.ToDouble(textBoxPriceFood.Text);

                if (FoodDAO.Instance.CheckFoodName(name) == false)
                {
                    if (FoodDAO.Instance.InsertFood(name, price))
                    {
                        MessageBox.Show("Success!!!", "Add Food", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Food", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }    
                }
                else
                {
                    MessageBox.Show("This Food Already Exist", "Add Food", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    

            }
            else
            {
                MessageBox.Show("You must fill out all of them", "Add Food", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        bool verify()
        {
            if(textBoxNameFood.Text.Trim() == "" || textBoxPriceFood.Text.Trim() == "" )
            {
                return false;
            }
            return true;
        }

        private void buttonEditFood_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                
                int id = Convert.ToInt32(textBoxSearch.Text.Trim());
                DataTable dt = FoodDAO.Instance.SearchFoodID(id);
                string name = textBoxNameFood.Text.Trim();
                double price = Convert.ToDouble(textBoxPriceFood.Text.Trim());
                if(name != dt.Rows[0][1].ToString())
                {
                    if (FoodDAO.Instance.CheckFoodName(name) == false)
                    {
                        if (FoodDAO.Instance.UpdateFoodByID(id, name, price))
                        {
                            MessageBox.Show("Success!!!", "Edit Food", MessageBoxButtons.OK, MessageBoxIcon.Information);                           
                        }
                        else
                        {
                            MessageBox.Show("Error", "Edit Food", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This Food Already Exist", "Edit Food", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } 
                else
                {
                    if (FoodDAO.Instance.UpdateFoodByID(id, name, price))
                    {
                        MessageBox.Show("Success!!!", "Edit Food", MessageBoxButtons.OK, MessageBoxIcon.Information);                      
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Food", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }    
                

            }
            else
            {
                MessageBox.Show("You must fill out all of them", "Edit Food", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonRemoveFood_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Trim() != "")
            {
                int id = Convert.ToInt32(textBoxSearch.Text.Trim());
                

                if (FoodDAO.Instance.CheckFoodID(id) == true)
                {
                    var reuslut = MessageBox.Show("Are you sure?", "Remove Food", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (reuslut == DialogResult.Yes)
                    {

                        if (FoodDAO.Instance.DeleteFoodByID(id))
                        {
                            MessageBox.Show("Success!!!", "Remove Food", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error", "Remove Food", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("This Food Not Exist", "Remove Food", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("You must fill out all of them", "Remove Food", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonSearchFood_Click(object sender, EventArgs e)
        {
            if(textBoxSearch.Text.Trim() != "")
            {
                int id = Convert.ToInt32(textBoxSearch.Text.Trim());
                //DataTable dt = FoodDAO.Instance.SearchFoodID(id);
                dataGridViewListFood.AllowUserToAddRows = false;
                dataGridViewListFood.ReadOnly = true;
                dataGridViewListFood.RowTemplate.Height = 80;
                dataGridViewListFood.DataSource = FoodDAO.Instance.SearchFoodID(id);

                textBoxNameFood.Text = FoodDAO.Instance.SearchFoodID(id).Rows[0][1].ToString();
                textBoxPriceFood.Text = FoodDAO.Instance.SearchFoodID(id).Rows[0][2].ToString();
            }    
            else
            {
                MessageBox.Show("You must fill out Id ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewListFood.AllowUserToAddRows = false;
            dataGridViewListFood.ReadOnly = true;
            dataGridViewListFood.RowTemplate.Height = 80;
            dataGridViewListFood.DataSource = FoodDAO.Instance.GetAllFood();
            textBoxNameFood.Text = "";
            textBoxPriceFood.Text = "";
            textBoxSearch.Text = "";

        }

        private void dataGridViewListFood_DoubleClick(object sender, EventArgs e)
        {
            textBoxNameFood.Text = dataGridViewListFood.CurrentRow.Cells[1].Value.ToString();
            textBoxPriceFood.Text = dataGridViewListFood.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
