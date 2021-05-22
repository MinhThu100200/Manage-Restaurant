﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageRes
{
    class Customer
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

        private int idHoaDon;

        public int IdHoaDon
        {
            get { return idHoaDon; }
            set { idHoaDon = value; }
        }
        #endregion


        public Customer() { }

        public Customer(int id, string ten, int idHoaDon)
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
