using System;
using System.Collections.Generic;
using System.Data;
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

        public int TinhTrang
        {
            get { return tinhtrang; }
            set { tinhtrang = value; }
        }

        private int soluongkhach;

        public int Soluongkhach
        {
            get { return soluongkhach; }
            set { soluongkhach = value; }
        }


        #endregion


        public Tables() { }

        public Tables(int id, string ten, int loai, int tinhtrang, int soluongKH)
        {
            this.Id = id;
            this.Ten = ten;
            this.Loai = loai;
            this.TinhTrang = tinhtrang;
            this.Soluongkhach = soluongKH;

        }


        public Tables(DataRow row)
        {
            this.Id = Convert.ToInt32(row["Id"]);
            this.Ten = row["Ten"].ToString();
            this.Loai = Convert.ToInt32(row["Loai"]);
            this.TinhTrang = Convert.ToInt32(row["TinhTrang"]);
            this.Soluongkhach = Convert.ToInt32(row["SoLuongKhach"]);

        }
    }
}
