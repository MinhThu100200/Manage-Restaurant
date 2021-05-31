using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageRes
{
    class WarehouseDAO
    {
        private static WarehouseDAO instance;

        public static WarehouseDAO Instance
        {
            get { if (instance == null) instance = new WarehouseDAO(); return instance; }
            private set { instance = value; }
        }

        private WarehouseDAO()
        {

        }

        public bool InsertWarehouse(string ten, int soluong)
        {
            string query = "INSERT INTO Kho( ten , soluong)"
                + " VALUES  ( @ten , @soluongkhach )";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ten, soluong }) > 0;
        }

        public bool DeleteWarehouseByID(int id)
        {
            string query = "delete from Kho where id = @id ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id }) > 0;
        }

        public DataTable GetAllWarehouse()
        {
            string query = "SELECT * FROM Kho ";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetWarehouseByID(int id)
        {
            string query = "SELECT * FROM Kho where id = @id ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id });
        }

        public bool UpdateWarehouseByID(int id, string ten, int soluong)
        {
            string query = "UPDATE Kho SET Ten = @ten , SoLuong = @soluong WHERE Id = @id ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ten, soluong, id }) > 0;
        }

        public List<Warehouse> GetAllTableList()
        {
            List<Warehouse> listWarehouse = new List<Warehouse>();
            string query = "select * from Kho ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Warehouse warehouse = new Warehouse(item);
                listWarehouse.Add(warehouse);
            }


            return listWarehouse;

        }
    }
}
