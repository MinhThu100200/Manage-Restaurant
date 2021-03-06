using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageRes
{
    class CheckOutDAO
    {
        private static CheckOutDAO instance;

        public static CheckOutDAO Instance
        {
            get { if (instance == null) instance = new CheckOutDAO(); return instance; }
            private set { instance = value; }
        }

        private CheckOutDAO()
        {

        }

        public bool InsertCheckOut(DateTime ngay, int idNhanVien)
        {
            string query = "INSERT INTO CheckOut( ThoiGianRa, idNhanVien)"
                + " VALUES  ( @ten , @idhoadon )";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ngay, idNhanVien }) > 0;
        }

        //public bool CheckCustomerID(int id)
        //{
        //    string query = "Select * from KhachHang where id = @id";
        //    return DataProvider.Instance.ExecuteQuery(query, new object[] { id }).Rows.Count > 0;
        //}
        //public bool CheckCustomerCmnd(int cmnd)
        //{
        //    string query = "Select * from KhachHang where Cmnd = @cmnd";
        //    return DataProvider.Instance.ExecuteQuery(query, new object[] { cmnd }).Rows.Count > 0;
        //}

        //public bool DeleteCustomerByID(int id)
        //{
        //    string query = "delete from KhachHang where id = @id ";
        //    return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id }) > 0;
        //}

        public DataTable GetAllCheckIn()
        {
            string query = "SELECT * FROM CheckOut ";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetCheckInByID(int id)
        {
            string query = "SELECT * FROM CheckOut where id = @id ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id });
        }

        public DataTable GetCheckInByIdNV(int idnv, DateTime ngay)
        {
            string query = "SELECT * FROM CheckOut where IdNhanVien = @idnhanvien and ThoiGianRa = @ngay";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { idnv, ngay });
        }

        //public bool UpdateCustomerByID(int id, string ten, int idHoaDon, string cmnd)
        //{
        //    string query = "UPDATE KhachHang SET Ten = @ten , IdHoaDon = @idhoadon , Cmnd = @cmnd WHERE Id = @id ";
        //    return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ten, idHoaDon, cmnd, id }) > 0;
        //}

        //public List<Customer> GetAllCustomerList()
        //{
        //    List<Customer> listCustomer = new List<Customer>();
        //    string query = "select * from KhachHang";

        //    DataTable data = DataProvider.Instance.ExecuteQuery(query);

        //    foreach (DataRow item in data.Rows)
        //    {
        //        Customer customer = new Customer(item);
        //        listCustomer.Add(customer);
        //    }


        //    return listCustomer;

        //}
    }
}
