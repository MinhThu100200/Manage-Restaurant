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
    public partial class CRUDTableForm : Form
    {
        public CRUDTableForm()
        {
            InitializeComponent();
        }

        private void CRUDTableForm_Load(object sender, EventArgs e)
        {
            dataGridViewListTable.ReadOnly = true;
            dataGridViewListTable.AllowUserToAddRows = false;
            dataGridViewListTable.RowTemplate.Height = 80;
            dataGridViewListTable.DataSource = TableDAO.Instance.GetAllTable();
            dataGridViewListTable.Columns[0].Width = 65;
            dataGridViewListTable.Columns[2].Width = 65;
            dataGridViewListTable.Columns[4].Width = 65;
            dataGridViewListTable.Columns[3].Width = 65;
            dataGridViewListTable.Columns[1].Width = 65;
            dataGridViewListTable.Columns[4].HeaderText = "So Luong Khach";

            comboBoxTypeTable.DataSource = TypeTableDAO.Instance.GetAllType();
            comboBoxTypeTable.DisplayMember = "Ten";
            comboBoxTypeTable.ValueMember = "id";
            comboBoxTypeTable.SelectedItem = null;

        }

        private void buttonAddTable_Click(object sender, EventArgs e)
        {
            if (verify())
            {

                string name = textBoxNameTable.Text.Trim();
                int state = Convert.ToInt32(textBoxStateTable.Text.Trim());
                int idloai = Convert.ToInt32(comboBoxTypeTable.SelectedValue);
                int quantity = (int)numericUpDownQuantity.Value;

                if (TableDAO.Instance.CheckTableName(name) == false)
                {
                    if (TableDAO.Instance.InsertTable(name, idloai, state, quantity))
                    {
                        MessageBox.Show("Success!!!", "Add Table", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("This Table Already Exist", "Add Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("You must fill out all of them", "Add Table", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        bool verify()
        {
            if(textBoxStateTable.Text.Trim() == "" || comboBoxTypeTable.SelectedValue == null || 
                textBoxNameTable.Text.Trim() == "" || numericUpDownQuantity.Value <= 0)
            {
                return false;
            }
            return true;
        }

        private void labelRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewListTable.ReadOnly = true;
            dataGridViewListTable.AllowUserToAddRows = false;
            //dataGridViewListTable.RowTemplate.Height = 80;
            dataGridViewListTable.DataSource = TableDAO.Instance.GetAllTable();

            textBoxNameTable.Text = "";
            textBoxSearch.Text = "";
            textBoxStateTable.Text = "";
            numericUpDownQuantity.Value = 0;
            comboBoxTypeTable.SelectedItem = null;

        }

        private void buttonEditTable_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                int id = Convert.ToInt32(textBoxSearch.Text.Trim());
                DataTable dt = TableDAO.Instance.GetTableByID(id);
                string name = textBoxNameTable.Text.Trim();
                int state = Convert.ToInt32(textBoxStateTable.Text.Trim());
                int idloai = Convert.ToInt32(comboBoxTypeTable.SelectedValue);
                int quantity = (int)numericUpDownQuantity.Value;
                if(name == dt.Rows[0]["Ten"].ToString())
                {
                    if (TableDAO.Instance.UpdateTableByID(id, name, idloai, state, quantity))
                    {
                        MessageBox.Show("Success!!!", "Edit Table", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }  
                else
                {
                    if (TableDAO.Instance.CheckTableName(name) == false)
                    {
                        if (TableDAO.Instance.InsertTable(name, idloai, state, quantity))
                        {
                            MessageBox.Show("Success!!!", "Edit Table", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Error", "Edit Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This Table Already Exist", "Edit Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
            }
            else
            {
                MessageBox.Show("You must fill out all of them", "Edit Table", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonRemoveTable_Click(object sender, EventArgs e)
        {


            int id = Convert.ToInt32(textBoxSearch.Text.Trim());

            if (TableDAO.Instance.CheckTableID(id))
            {
                var result = MessageBox.Show("Are you sure?", "Remove Table", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(result == DialogResult.Yes)
                {
                    if (TableDAO.Instance.DeleteTableByID(id))
                {
                        MessageBox.Show("Success!!!", "Remove Table", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                else
                    {
                        MessageBox.Show("Error", "Remove Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }    

                
            }
            else
            {
                MessageBox.Show("This Table Not Exist", "Remove Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }       
        }

        private void buttonSearchTable_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "")
            {
                int id = Convert.ToInt32(textBoxSearch.Text.Trim());
                DataTable dt = TableDAO.Instance.GetTableByID(id);
                dataGridViewListTable.ReadOnly = true;
                dataGridViewListTable.AllowUserToAddRows = false;
                //dataGridViewListTable.RowTemplate.Height = 80;
                dataGridViewListTable.DataSource = dt;

                textBoxNameTable.Text = dt.Rows[0][1].ToString();
                textBoxStateTable.Text = dt.Rows[0][3].ToString();
                numericUpDownQuantity.Value = Convert.ToInt32(dt.Rows[0][4].ToString());
                comboBoxTypeTable.SelectedValue = Convert.ToInt32(dt.Rows[0][2].ToString());
            }    
            else
            {
                MessageBox.Show("You must fill out ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
            
        }
    }
}
