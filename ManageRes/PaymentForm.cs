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
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void buttonConfirmPayment_Click(object sender, EventArgs e)
        {
            //DataTable dt = BillDAO.Instance.GetAllBill();
            DataTable total = BillDetailDAO.Instance.GetTotalBillDetailByID(GlobalsTable.tables.Id);
            //int n = dt.Rows.Count - 1;
            if(textBoxNameCustomer.Text.Trim() != "" && textBoxIdCard.Text.Trim() != "")
            {
                string name = textBoxNameCustomer.Text.Trim();
                string idcard = textBoxIdCard.Text.Trim();
               
                if (CustomerDAO.Instance.CheckCustomerCmnd(idcard) == false)
                {

                    if(CustomerDAO.Instance.InsertCustomer(name, idcard))
                    {
                        DataTable cus = CustomerDAO.Instance.GetCustomerByCmnd(idcard);
                        if (BillDAO.Instance.InsertBill(Globals.Users.Id, Convert.ToDouble(total.Rows[0][0].ToString()), DateTime.Now, Convert.ToInt32(cus.Rows[0][0].ToString())))
                        {
                            MessageBox.Show("Success!!!", "Payment with new customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        
                    }   
                    else
                    {
                        MessageBox.Show("Error!!!", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }    
                }  
                else
                {
                    DataTable cus = CustomerDAO.Instance.GetCustomerByCmnd(idcard);
                    if (BillDAO.Instance.InsertBill(Globals.Users.Id, Convert.ToDouble(total.Rows[0][0].ToString()), DateTime.Now, Convert.ToInt32(cus.Rows[0][0].ToString())))
                    {
                        MessageBox.Show("Success!!!", "Payment with old customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }    
                    
            } 
            else
            {
                
                if (BillDAO.Instance.InsertBillNoIdCus(Globals.Users.Id, Convert.ToDouble(total.Rows[0][0].ToString()), DateTime.Now))
                {
                    MessageBox.Show("Success!!!", "Payment with old customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                
            }    
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
