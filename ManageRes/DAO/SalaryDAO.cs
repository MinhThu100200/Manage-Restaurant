using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageRes
{
    class SalaryDAO
    {
        private static SalaryDAO instance;

        public static SalaryDAO Instance
        {
            get { if (instance == null) instance = new SalaryDAO(); return instance; }
            private set { instance = value; }
        }

        private SalaryDAO()
        {

        }

        public bool InsertProduct(DateTime ngay, double luong, int idNhanVien)
        {
           
            string query = "INSERT INTO TinhLuong( Ngay ,Luong ,IdNhanVien )"
                + " VALUES  ( @ngay , @luong , @idnhanvien)";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ngay, luong, idNhanVien }) > 0;
        }

        public bool CheckIdNhanVien(int id)
        {
            string query = "Select * from TinhLuong where idnhanvien = @idnhanvien";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id }).Rows.Count > 0;
        }

        public bool CheckID(int id)
        {
            string query = "Select * from TinhLuong where id = @id";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id }).Rows.Count > 0;
        }

        public DataTable SearchIDNhanVienNgay(int id, DateTime ngay)
        {
            string query = "Select * from TinhLuong where idnhanvien = @idnhanvien and ngay = @ngay";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id, ngay });
        }

        public bool DeleteByID(int id)
        {
            string query = "delete from TinhLuong where id = @id ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id }) > 0;
        }

        public DataTable GetAllSalary()
        {
            string query = "SELECT * FROM TinhLuong ";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        //public DataTable GetAllFoodExist()
        //{
        //    string query = "SELECT * FROM Mon, Kho where Mon.Ten = Kho.Ten and Kho.SoLuong >= 3 ";
        //    return DataProvider.Instance.ExecuteQuery(query);
        //}

        public DataTable GetSalaryByID(int id)
        {
            string query = "SELECT * FROM TinhLuong where id = @id ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id });
        }

        public DataTable GetSalaryByIDNV(int id)
        {
            string query = "SELECT * FROM TinhLuong where idnhanvien = @idnhanvien ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id });
        }

        public bool UpdateFoodByID(int id, DateTime ngay, double luong, int idNhanVien)
        {
            string query = "UPDATE TinhLuong SET Ngay = @ngay , Luong = @luong , IdNhanVien = @idnhanvien WHERE Id = @id ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ngay, luong, idNhanVien, id }) > 0;
        }

     
    }
}
