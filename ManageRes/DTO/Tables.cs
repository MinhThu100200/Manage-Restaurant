using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageRes
{
    class Tables
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

        private int loai;

        public int Loai
        {
            get { return loai; }
            set { loai = value; }
        }

        private int tinhtrang;

        public int Tinhtrang
        {
            get { return Tinhtrang; }
            set { Tinhtrang = value; }
        }

        private int soluongKH;

        public int SoluongKH
        {
            get { return soluongKH; }
            set { soluongKH = value; }
        }


        #endregion


        public Tables() { }

        public Tables(int id, string ten, int idHoaDon)
        {
            this.Id = id;
            this.Ten = ten;
            this.IdHoaDon = idHoaDon;

        }


        public Customer(DataRow row)
        {
            this.Id = Convert.ToInt32(row["Id"]);
            this.Ten = row["Ten"].ToString();
            this.IdHoaDon = Convert.ToInt32(row["IdHoaDon"]);

        }
    }
}
