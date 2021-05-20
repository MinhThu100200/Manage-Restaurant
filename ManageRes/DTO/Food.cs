using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageRes
{
    class Food
    {
        #region Para
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string ten;

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        private double gia;

        public double Gia
        {
            get { return gia; }
            set { gia = value; }
        }
        #endregion


        public Food() { }

        public Food(int id, string ten, double gia)
        {
            this.Id = id;
            this.Ten = ten;
            this.Gia = gia;
           
        }


        public Food(DataRow row)
        {
            this.Id = Convert.ToInt32(row["Id"]);
            this.Ten = row["Ten"].ToString();
            this.Gia = (double) Convert.ToInt32(row["Gia"]);

        }
    }
}
