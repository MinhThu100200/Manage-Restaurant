using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageRes
{
    class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return instance; }
            private set { instance = value; }
        }

        private TableDAO()
        {

        }

        public bool InsertTable(string ten, int loai, int tinhtrang, int soluongkhach)
        {
            string query = "INSERT INTO Ban( ten ,loai, tinhtrang, soluongkhach)"
                + " VALUES  ( @ten , @loai, @tinhtrang, @soluongkhach )";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ten, loai, tinhtrang, soluongkhach }) > 0;
        }

        public bool CheckTableID(int id)
        {
            string query = "Select * from Ban where id = @id";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id }).Rows.Count > 0;
        }

        public bool DeleteTableByID(int id)
        {
            string query = "delete from Ban where id = @id ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id }) > 0;
        }

        public DataTable GetAllTable()
        {
            string query = "SELECT * FROM Ban ";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetTableByID(int id)
        {
            string query = "SELECT * FROM Ban where id = @id ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id });
        }

        public bool UpdateTableByID(int id, string ten, int loai, int tinhtrang, int soluongkhach)
        {
            string query = "UPDATE Ban SET Ten = @ten , Loai = @loai, TinhTrang = @tinhtrang, SoLuongKhach = @soluongkhach WHERE Id = @id ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ten, loai, tinhtrang, soluongkhach, id }) > 0;
        }

        public List<Tables> GetAllTableList()
        {
            List<Tables> listTable = new List<Tables>();
            string query = "select * from Ban";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Tables tables = new Tables(item);
                listTable.Add(tables);
            }


            return listTable;

        }
    }
}
