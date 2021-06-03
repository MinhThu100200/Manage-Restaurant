using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageRes
{
    class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return instance; }
            private set { instance = value; }
        }

        private BillDAO()
        {

        }

        public bool InsertBill(int idnhanvien, double tongtien, DateTime ngay, int idkhach)
        {
            string query = "INSERT INTO HoaDon( IdNhanVien , TongTien, Ngay, IdKhach)"
                + " VALUES  ( @idmon , @idhoadon , @soluong , @idkhach )";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { idnhanvien, tongtien, ngay, idkhach }) > 0;
        }

        public bool InsertBillNoIdCus(int idnhanvien, double tongtien, DateTime ngay)
        {
            string query = "INSERT INTO HoaDon( IdNhanVien , TongTien, Ngay)"
                + " VALUES  ( @idmon , @idhoadon , @soluong )";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { idnhanvien, tongtien, ngay}) > 0;
        }

        public bool DeleteBillByID(int id)
        {
            string query = "delete from HoaDon where id = @id ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id }) > 0;
        }

        public DataTable GetAllBill()
        {
            string query = "SELECT * FROM HoaDon ";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetBillByID(int id)
        {
            string query = "SELECT * FROM HoaDon where id = @id ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id });
        }

        public DataTable GetBillByUserID(int id)
        {
            string query = "SELECT * FROM HoaDon where idnhanvien = @id ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id });
        }

        //public DataTable GetBillToPayment(int idhoadon, int idban)
        //{
        //    string query = "SELECT * FROM HoaDon where idhoadon = @id , idban = @idban ";
        //    return DataProvider.Instance.ExecuteQuery(query, new object[] { idhoadon, idban });
        //}

        public bool UpdateBillByID(int id, int idnhanvien, double tongtien, DateTime ngay, int idkhach)
        {
            string query = "UPDATE ThongTin SET IdNhanVien = @idnhanvien , TongTien = @idhoadon , Ngay = @soluong , IdKhach = @gia WHERE Id = @id ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { idnhanvien, tongtien, ngay, idkhach, id }) > 0;
        }

        public bool UpdateIdCustomerByID(int id, int idkhach)
        {
            string query = "UPDATE ThongTin SET IdKhach = @gia WHERE Id = @id ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { idkhach, id }) > 0;
        }


    }
}
