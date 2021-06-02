using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageRes
{
    class TypeTableDAO
    {
        private static TypeTableDAO instance;

        public static TypeTableDAO Instance
        {
            get { if (instance == null) instance = new TypeTableDAO(); return instance; }
            private set { instance = value; }
        }

        private TypeTableDAO()
        {

        }

        public bool CheckTypeID(int id)
        {
            string query = "Select * from GiaLoai where id = @id";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id }).Rows.Count > 0;
        }

        public DataTable SearchTypeID(int id)
        {
            string query = "Select * from GiaLoai where id = @id";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id });
        }
    
        public DataTable GetAllType()
        {
            string query = "SELECT * FROM GiaLoai ";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetTypeByID(int id)
        {
            string query = "SELECT * FROM GiaLoai where id = @id ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id });
        }

       

       
    }
}
