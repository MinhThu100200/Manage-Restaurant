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

        private int trangthai;

        public int TrangThai
        {
            get { return trangthai; }
            set { trangthai = value; }
        }
        #endregion


        public Food() { }

        public Food(int id, string ten, double gia, int trangthai)
        {
            this.Id = id;
            this.Ten = ten;
            this.Gia = gia;
            this.trangthai = trangthai;
        }


        public Food(DataRow row)
        {
            this.Id = Convert.ToInt32(row["Id"]);
            this.Ten = row["Ten"].ToString();
            this.Gia = Convert.ToDouble(row["Gia"]);
            this.trangthai = Convert.ToInt32(row["TrangThai"]);
        }
    }
}
