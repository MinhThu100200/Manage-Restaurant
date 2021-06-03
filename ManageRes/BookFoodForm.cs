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
    public partial class BookFoodForm : Form
    {
        public BookFoodForm()
        {
            InitializeComponent();
        }

        private void BookFoodForm_Load(object sender, EventArgs e)
        {
            DataTable dt = TableDAO.Instance.GetAllTable();
            for(int i = 0; i < dt.Rows.Count; i++)
            {

                if(dt.Rows[i][1].ToString() == buttonVIP1.Text)
                {
                    setState(buttonVIP1, dt.Rows[i]);
                       
                }
                else if(dt.Rows[i][1].ToString() == buttonVIP2.Text)
                {
                    setState(buttonVIP2, dt.Rows[i]);
                }
                else if(dt.Rows[i][1].ToString() == buttonVIP3.Text)
                {
                    setState(buttonVIP3, dt.Rows[i]);
                }    
                else if(dt.Rows[i][1].ToString() == buttonVIP4.Text)
                {
                    setState(buttonVIP4, dt.Rows[i]);
                }  
                else if(dt.Rows[i][1].ToString() == buttonVIP5.Text)
                {
                    setState(buttonVIP5, dt.Rows[i]);
                }
                else if(dt.Rows[i][1].ToString() == buttonVIP6.Text)
                {
                    setState(buttonVIP6, dt.Rows[i]);
                }    
                else if(dt.Rows[i][1].ToString() == buttonNormal1.Text)
                {
                    setState(buttonNormal1, dt.Rows[i]);
                }   
                else if(dt.Rows[i][1].ToString() == buttonNormal2.Text)
                {
                    setState(buttonNormal2, dt.Rows[i]);
                }   
                else if(dt.Rows[i][1].ToString() == buttonNormal3.Text)
                {
                    setState(buttonNormal3, dt.Rows[i]);
                }   
                else if(dt.Rows[i][1].ToString() == buttonNormal4.Text)
                {
                    setState(buttonNormal4, dt.Rows[i]);
                }   
                else if(dt.Rows[i][1].ToString() == buttonNormal5.Text)
                {
                    setState(buttonNormal5, dt.Rows[i]);
                }   
                else if (dt.Rows[i][1].ToString() == buttonNormal6.Text)
                {
                    setState(buttonNormal6, dt.Rows[i]);
                }
                else if(dt.Rows[i][1].ToString() == buttonNormal7.Text)
                {
                    setState(buttonNormal7, dt.Rows[i]);
                }   
                else if(dt.Rows[i][1].ToString() == buttonNormal8.Text)
                {
                    setState(buttonNormal8, dt.Rows[i]);
                }   
                else if(dt.Rows[i][1].ToString() == buttonNormal9.Text)
                {
                    setState(buttonNormal9, dt.Rows[i]);
                }                    
            }    
        }
        public void setState(Button btn, DataRow dr)
        {
            if (dr[3].ToString() == "1")
            {
                btn.BackColor = Color.Red;
            }
            else
            {
                btn.BackColor = Color.Green;
            }    
        }

        private void buttonVIP1_Click(object sender, EventArgs e)
        {
            tableType("VIP1", buttonVIP2);
        }

        private void buttonVIP3_Click(object sender, EventArgs e)
        {
            tableType("VIP3", buttonVIP3);
        }

        private void buttonVIP5_Click(object sender, EventArgs e)
        {
            tableType("VIP5", buttonVIP5);
        }

        private void buttonVIP6_Click(object sender, EventArgs e)
        {
            tableType("VIP6", buttonVIP6);
        }

        private void buttonVIP4_Click(object sender, EventArgs e)
        {
            tableType("VIP4", buttonVIP4);
        }

        private void buttonVIP2_Click(object sender, EventArgs e)
        {
            tableType("VIP2", buttonVIP2);
        }

        private void buttonNormal1_Click(object sender, EventArgs e)
        {
            tableType("Normal1", buttonNormal1);
        }

        private void buttonNormal2_Click(object sender, EventArgs e)
        {
            tableType("Normal2", buttonNormal2);
        }

        private void buttonNormal3_Click(object sender, EventArgs e)
        {
            tableType("Normal3", buttonNormal3);
        }

        private void buttonNormal6_Click(object sender, EventArgs e)
        {
            tableType("Normal6", buttonNormal6);
        }

        private void buttonNormal5_Click(object sender, EventArgs e)
        {
            tableType("Normal5", buttonNormal5);
        }

        private void buttonNormal4_Click(object sender, EventArgs e)
        {
            tableType("Normal4", buttonNormal4);
        }

        private void buttonNormal7_Click(object sender, EventArgs e)
        {
            tableType("Normal7", buttonNormal7);
        }

        private void buttonNormal8_Click(object sender, EventArgs e)
        {
            tableType("Normal8", buttonNormal8);
        }

        private void buttonNormal9_Click(object sender, EventArgs e)
        {
            tableType("Normal9", buttonNormal9);
        }

        public void tableType(string nameTable, Button btn)
        {
            DataTable dt = TableDAO.Instance.GetTableByName(nameTable);
            Tables tables = new Tables(dt.Rows[0]);
            GlobalsTable.tables = tables;
            if(GlobalsTable.tables.TinhTrang == 0)
            {
                ChooseFood frm = new ChooseFood();
                frm.ShowDialog();
            }    
            else if(GlobalsTable.tables.TinhTrang == 1)
            {
               
                var result = MessageBox.Show("Empty?", "Infomation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    int id = GlobalsTable.tables.Id;
                    if(TableDAO.Instance.UpdateStateByID(id))
                    {
                        btn.BackColor = Color.Green;
                    }    
                }  
                else
                {
                    OptionServiceTableForm frm = new OptionServiceTableForm();
                    frm.ShowDialog();
                }    
            }
            else
            {
                MessageBox.Show("Table is under constructor", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
            
        }
    }
}
