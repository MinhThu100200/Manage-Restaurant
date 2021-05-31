using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageRes
{
    class Warehouse
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

        private int soluong;

        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }


        #endregion


        public Warehouse() { }

        public Warehouse(int id, string ten, int soluong)
        {
            this.Id = id;
            this.Ten = ten;
          
            this.Soluong = soluong;

        }


        public Warehouse(DataRow row)
        {
            this.Id = Convert.ToInt32(row["Id"]);
            this.Ten = row["Ten"].ToString();
            this.Soluong = Convert.ToInt32(row["SoLuong"]);

        }
    }
}
