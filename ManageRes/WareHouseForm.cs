﻿using System;
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
    public partial class WareHouseForm : Form
    {
        public WareHouseForm()
        {
            InitializeComponent();
        }

        private void WareHouseForm_Load(object sender, EventArgs e)
        {
            dataGridViewListFood.AllowUserToAddRows = false;
            dataGridViewListFood.ReadOnly = true;
            dataGridViewListFood.RowTemplate.Height = 80;
            dataGridViewListFood.DataSource = WarehouseDAO.Instance.GetAllWarehouse();

        }

        private void buttonSearchFood_Click(object sender, EventArgs e)
        {
            if(textBoxSearch.Text.Trim() != "")
            {
                int id = Convert.ToInt32(textBoxSearch.Text.Trim());
                dataGridViewListFood.DataSource = WarehouseDAO.Instance.GetWarehouseByID(id);
            }    
        }

        private void buttonAddFood_Click(object sender, EventArgs e)
        {
            if(textBoxNameFood.Text.Trim() != "" && numericUpDownAmount.Value > 0)
            {
                string name = textBoxNameFood.Text.Trim();
                int amount = (int)numericUpDownAmount.Value;
                if(WarehouseDAO.Instance.CheckFoodName(name) == false)
                {
                    if (WarehouseDAO.Instance.InsertWarehouse(name, amount))
                    {
                        MessageBox.Show("Success!!!", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error!!", "Add product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }    
                else
                {
                    MessageBox.Show("This name already exist", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }    
            }
            {
                MessageBox.Show("You must fill name and amount >= 1", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
            
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewListFood.AllowUserToAddRows = false;
            dataGridViewListFood.ReadOnly = true;
            dataGridViewListFood.RowTemplate.Height = 80;
            dataGridViewListFood.DataSource = WarehouseDAO.Instance.GetAllWarehouse();

            textBoxNameFood.Text = "";
            numericUpDownAmount.Value = 0;
            textBoxSearch.Text = "";
        }

        private void buttonEditFood_Click(object sender, EventArgs e)
        {

        }
    }
}
