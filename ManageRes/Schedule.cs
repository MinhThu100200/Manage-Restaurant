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
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            dataGridViewGroup1.AllowUserToAddRows = false;
            dataGridViewGroup1.ReadOnly = true;
            dataGridViewGroup1.RowTemplate.Height = 80;
            DataTable g1 = new DataTable();
            g1.Columns.Add("Ho Ten", typeof(System.String));
            g1.Columns.Add("Dia Chi", typeof(System.String));
            g1.Columns.Add("Ngay Sinh", typeof(System.String));
            g1.Columns.Add("Ca Sang (7h - 11h, 12h - 4h)", typeof(System.String));
            g1.Columns.Add("Ca Chieu (11h - 3h, 4h - 8h)", typeof(System.String));
            g1.Columns.Add("Ca Toi (2h - 5h, 6h - 10h)", typeof(System.String));

            dataGridViewGroup2.AllowUserToAddRows = false;
            dataGridViewGroup2.ReadOnly = true;
            dataGridViewGroup2.RowTemplate.Height = 80;
            DataTable g2 = new DataTable();
            g2.Columns.Add("Ho Ten", typeof(System.String));
            g2.Columns.Add("Ngay Sinh", typeof(System.String));
            g2.Columns.Add("Sdt", typeof(System.String));
            g2.Columns.Add("Ca Sang (7h - 11h, 12h - 4h)", typeof(System.String));
            g2.Columns.Add("Ca Chieu (11h - 3h, 4h - 8h)", typeof(System.String));
            g2.Columns.Add("Ca Toi (2h - 5h, 6h - 10h)", typeof(System.String));
           
            dataGridViewGroup3.ReadOnly = true;
            dataGridViewGroup3.AllowUserToAddRows = false;
            dataGridViewGroup3.RowTemplate.Height = 80;
            DataTable g3 = new DataTable();
            g3.Columns.Add("Ho Ten", typeof(System.String));
            g3.Columns.Add("Ngay Sinh", typeof(System.String));
            g3.Columns.Add("Sdt", typeof(System.String));
            g3.Columns.Add("Ca Sang (7h - 11h, 12h - 4h)", typeof(System.String));
            g3.Columns.Add("Ca Chieu (11h - 3h, 4h - 8h)", typeof(System.String));
            g3.Columns.Add("Ca Toi (2h - 5h, 6h - 10h)", typeof(System.String));

            dataGridViewSchedule.ReadOnly = true;
            dataGridViewSchedule.AllowUserToAddRows = false;
            dataGridViewSchedule.RowTemplate.Height = 80;
            DataTable schedule = new DataTable();
            schedule.Columns.Add("HoTen", typeof(System.String));
            schedule.Columns.Add("Ngay Sinh", typeof(System.String));
            schedule.Columns.Add("Sdt", typeof(System.String));
            schedule.Columns.Add("Ca Sang (7-3h)", typeof(System.String));
            
            schedule.Columns.Add("Ca Sang (3-11h)", typeof(System.String));


            int days = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

            DataTable ql = UserInfoDAO.Instance.GetUserInfoByRole(1);
            string dauql = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).Date.ToString();
            string dauql1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).Date.AddDays(15).ToString();

            string cuoiql = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).Date.AddDays(16).ToString();
            string cuoiql1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).Date.AddDays(days - 1).ToString();


            for(int j = 0; j < ql.Rows.Count; j++)
            {
                if(j == 0)
                {
                    schedule.Rows.Add(ql.Rows[j][0].ToString(), ql.Rows[j][1].ToString(), ql.Rows[j][2].ToString(), dauql +"-"+ dauql1, cuoiql +"-"+ cuoiql1);
                }
                else
                {
                    schedule.Rows.Add(ql.Rows[j][0].ToString(), ql.Rows[j][1].ToString(), ql.Rows[j][2].ToString(), cuoiql + "-" + cuoiql1, dauql + "-" + dauql1);
                }
            }

            dataGridViewSchedule.DataSource = schedule;
            DataTable dt = UserInfoDAO.Instance.GetUserInfoByRole(2);
            float temp = dt.Rows.Count / 3;

            //string month = DateTime.Now.Month.ToString();
            //string year = DateTime.Now.Year.ToString();


            string dau = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).Date.ToString();
            string dau1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).Date.AddDays(10).ToString();

            string giua = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).Date.AddDays(11).ToString();
            string giua1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).Date.AddDays(20).ToString();

            string cuoi = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).Date.AddDays(21).ToString();
            string cuoi1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).Date.AddDays(days - 1).ToString();

            //string [] ngay = new string[] { }
            if (temp - (int)temp > 0.5 && days == 30)
            {
                int soluong = (dt.Rows.Count - 2) / 3;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i <= soluong)
                    {
                        g1.Rows.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), giua + "-" + giua1, dau + "-" + dau1, cuoi + "-" + cuoi1);
                    }
                    else if (i > soluong && i <= soluong * 2)
                    {
                        g2.Rows.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), cuoi + "-" + cuoi1, giua + "-" + giua1, dau + "-" + dau1);
                    }
                    else
                    {
                        g3.Rows.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dau + "-" + dau1, cuoi + "-" + cuoi1, giua + "-" + giua1);
                    }
                }
            }
            else if (temp - (int)temp == 0 && (days == 28 || days == 29))
            {
                int soluong = (dt.Rows.Count - 1) / 3;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i < soluong)
                    {
                        g1.Rows.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), cuoi + "-" + cuoi1, giua + "-" + giua1, dau + "-" + dau1);
                    }
                    else if (i > soluong && i <= soluong * 2)
                    {
                        g2.Rows.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dau + "-" + dau1, cuoi + "-" + cuoi1, giua + "-" + giua1);
                    }
                    else
                    {
                        g3.Rows.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), giua + "-" + giua1, dau + "-" + dau1, cuoi + "-" + cuoi1);
                    }
                }
            }
            else
            {
                int soluong = (dt.Rows.Count - 1) / 3;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i <= soluong)
                    {
                        g1.Rows.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dau + "-" + dau1, cuoi + "-" + cuoi1, giua + "-" + giua1);
                    }
                    else if (i > soluong && i <= soluong * 2)
                    {
                        g2.Rows.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), giua + "-" + giua1, dau + "-" + dau1, cuoi + "-" + cuoi1);
                    }
                    else
                    {
                        g3.Rows.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), cuoi + "-" + cuoi1, giua + "-" + giua1, dau + "-" + dau1);
                    }
                }
            }

            dataGridViewGroup1.DataSource = g1;
            dataGridViewGroup2.DataSource = g2;
            dataGridViewGroup3.DataSource = g3;
        }
    }
}
