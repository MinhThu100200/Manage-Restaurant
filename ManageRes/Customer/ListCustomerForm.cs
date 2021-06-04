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
    public partial class ListCustomerForm : Form
    {
        public ListCustomerForm()
        {
            InitializeComponent();
        }

        private void ListCustomerForm_Load(object sender, EventArgs e)
        {
            dataGridViewListCustomer.AllowUserToAddRows = false;
            dataGridViewListCustomer.ReadOnly = true;
            dataGridViewListCustomer.RowTemplate.Height = 80;
            dataGridViewListCustomer.DataSource = CustomerDAO.Instance.GetAllCustomer();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Trim() != "" && textBoxNameCustomer.Text.Trim() != "" && textBoxIdCard.Text.Trim() != "")
            {
                string name = textBoxNameCustomer.Text.Trim();
                string idcard = textBoxIdCard.Text.Trim();
                int id = Convert.ToInt32(textBoxSearch.Text);
                if (CustomerDAO.Instance.CheckCustomerID(id))
                {
                    var result = MessageBox.Show("Are you sure?", "Remove Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if(result == DialogResult.Yes)
                    {
                        if (CustomerDAO.Instance.DeleteCustomerByID(id))
                        {
                            MessageBox.Show("Success!!!", "Remove Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error!!", "Remove Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }    
                    
                }
                else
                {
                    MessageBox.Show("This ID not Exist", "Remove Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            else
            {
                MessageBox.Show("You must fill out all of them", "Remove Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if ( textBoxSearch.Text.Trim() != "" && textBoxNameCustomer.Text.Trim() != "" && textBoxIdCard.Text.Trim() != "")
            {
                string name = textBoxNameCustomer.Text.Trim();
                string idcard = textBoxIdCard.Text.Trim();
                int id = Convert.ToInt32(textBoxSearch.Text);
                if(CustomerDAO.Instance.CheckCustomerID(id))
                {
                    if (CustomerDAO.Instance.UpdateCustomerByID(id, name, idcard))
                    {
                        MessageBox.Show("Success!!!", "Edit Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error!!", "Edit Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }  
                else
                {
                    MessageBox.Show("This ID not Exist", "Edit Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }    
                

            }
            else
            {
                MessageBox.Show("You must fill out all of them", "Edit Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(textBoxNameCustomer.Text.Trim() != "" && textBoxIdCard.Text.Trim() != "")
            {
                string name = textBoxNameCustomer.Text.Trim();
                string idcard = textBoxIdCard.Text.Trim();

                if(CustomerDAO.Instance.CheckCustomerCmnd(idcard) == false)
                {
                    if(CustomerDAO.Instance.InsertCustomer(name, idcard))
                    {
                        MessageBox.Show("Success!!!", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }    
                    else
                    {
                        MessageBox.Show("Error!!", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }    
                } 
                else
                {
                    MessageBox.Show("This IdCard already exist", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }    
                
            }   
            else
            {
                MessageBox.Show("You must fill out all of them", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewListCustomer.AllowUserToAddRows = false;
            dataGridViewListCustomer.ReadOnly = true;
            dataGridViewListCustomer.RowTemplate.Height = 80;
            dataGridViewListCustomer.DataSource = CustomerDAO.Instance.GetAllCustomer();

            textBoxIdCard.Text = "";
            textBoxNameCustomer.Text = "";
            textBoxSearch.Text = "";
        }

        private void buttonSearchFood_Click(object sender, EventArgs e)
        {
            if(textBoxSearch.Text.Trim() != "")
            {
                int id = Convert.ToInt32(textBoxSearch.Text);
                dataGridViewListCustomer.DataSource = CustomerDAO.Instance.GetCustomerByID(id);

                
            }    
        }
    }
}
