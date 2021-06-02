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
            tableType("VIP1");
        }

        private void buttonVIP3_Click(object sender, EventArgs e)
        {
            tableType("VIP3");
        }

        private void buttonVIP5_Click(object sender, EventArgs e)
        {
            tableType("VIP5");
        }

        private void buttonVIP6_Click(object sender, EventArgs e)
        {
            tableType("VIP6");
        }

        private void buttonVIP4_Click(object sender, EventArgs e)
        {
            tableType("VIP4");
        }

        private void buttonVIP2_Click(object sender, EventArgs e)
        {
            tableType("VIP2");
        }

        private void buttonNormal1_Click(object sender, EventArgs e)
        {
            tableType("Normal1");
        }

        private void buttonNormal2_Click(object sender, EventArgs e)
        {
            tableType("Normal2");
        }

        private void buttonNormal3_Click(object sender, EventArgs e)
        {
            tableType("Normal3");
        }

        private void buttonNormal6_Click(object sender, EventArgs e)
        {
            tableType("Normal6");
        }

        private void buttonNormal5_Click(object sender, EventArgs e)
        {
            tableType("Normal5");
        }

        private void buttonNormal4_Click(object sender, EventArgs e)
        {
            tableType("Normal4");
        }

        private void buttonNormal7_Click(object sender, EventArgs e)
        {
            tableType("Normal7");
        }

        private void buttonNormal8_Click(object sender, EventArgs e)
        {
            tableType("Normal8");
        }

        private void buttonNormal9_Click(object sender, EventArgs e)
        {
            tableType("Normal9");
        }

        public void tableType(string nameTable)
        {
            DataTable dt = TableDAO.Instance.GetTableByName(nameTable);
            Tables tables = new Tables(dt.Rows[0]);
            GlobalsTable.tables = tables;
            if(GlobalsTable.tables.TinhTrang == 0)
            {
                ChooseFood frm = new ChooseFood();
                frm.ShowDialog();
            }    
            else
            {
                MessageBox.Show("Table is booked", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
