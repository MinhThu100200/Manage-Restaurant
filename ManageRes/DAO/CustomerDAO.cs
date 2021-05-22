using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageRes
{
    class CustomerDAO
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance
        {
            get { if (instance == null) instance = new CustomerDAO(); return instance; }
            private set { instance = value; }
        }

        private CustomerDAO()
        {

        }

        public bool InsertCustomer(string ten)
        {
            string query = "INSERT INTO KhachHang( ten)"
                + " VALUES  ( @ten)";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ten}) > 0;
        }

        public bool CheckCustomerID(int id)
        {
            string query = "Select * from KhachHang where id = @id";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id }).Rows.Count > 0;
        }

        public bool DeleteCustomerByID(int id)
        {
            string query = "delete from KhachHang where id = @id ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id }) > 0;
        }

        public DataTable GetAllCustomer()
        {
            string query = "SELECT * FROM KhachHang ";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetCustomerByID(int id)
        {
            string query = "SELECT * FROM KhachHang where id = @id ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id });
        }

        public bool UpdateCustomerByID(int id, string ten, int idHoaDon)
        {
            string query = "UPDATE KhachHang SET Ten = @ten , IdHoaDon = @idhoadon WHERE Id = @id ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ten, idHoaDon, id }) > 0;
        }

        public List<Customer> GetAllCustomerList()
        {
            List<Customer> listCustomer = new List<Customer>();
            string query = "select * from KhachHang";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Customer customer = new Customer(item);
                listCustomer.Add(customer);
            }


            return listCustomer;

        }
    }
}
