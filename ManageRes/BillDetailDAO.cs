﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageRes
{
    class BillDetailDAO
    {
        private static BillDetailDAO instance;

        public static BillDetailDAO Instance
        {
            get { if (instance == null) instance = new BillDetailDAO(); return instance; }
            private set { instance = value; }
        }

        private BillDetailDAO()
        {

        }

        public bool InsertBillDetail(int idmon, int soluong, double gia, int idban)
        {
            string query = "INSERT INTO HoaDonChiTiet( IdMon , SoLuong, Gia, IdBan)"
                + " VALUES  ( @idmon , @soluong , @gia , @idban )";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { idmon, soluong, gia, idban }) > 0;
        }

        public bool DeleteBillDetailByID(int id)
        {
            string query = "delete from HoaDonChiTiet where id = @id ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id }) > 0;
        }

        public DataTable GetAllBillDetail()
        {
            string query = "SELECT * FROM HoaDonChiTiet ";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetBillDetailByID(int id)
        {
            string query = "SELECT * FROM HoaDonChiTiet where id = @id ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id });
        }

        public DataTable GetBillDetailToPayment(int idban)
        {
            string query = "SELECT * FROM HoaDonChiTiet where idhoadon is null and idban = @idban ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { idban });
        }
        public DataTable GetTotalBillDetailByID(int idban)
        {
            string query = "SELECT sum(Gia*SoLuong) as Tong FROM HoaDonChiTiet where idhoadon is null and idban = @idban ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { idban });
        }

        public bool UpdateBillDetailByID(int id, int idmon, int idhoadon, int soluong, double gia, int idban)
        {
            string query = "UPDATE ThongTinChiTiet SET IdMon = @idmon , IdHoaDon = @idhoadon , soluong = @soluong , Gia = @gia , idban = @idban WHERE Id = @id ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { idmon, idhoadon, soluong, gia, idban, id }) > 0;
        }

        public bool UpdateBillDetailPayment( int idhoadon, int idban)
        {
            string query = "UPDATE ThongTinChiTiet SET IdHoaDon = @idhoadon WHERE IdBan = @idban and IdHoaDon is null ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { idhoadon, idban}) > 0;
        }

    }
}
