using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageRes
{
    class UsersDAO
    {
        private static UsersDAO instance;

        public static UsersDAO Instance
        {
            get { if (instance == null) instance = new UsersDAO(); return instance; }
            private set { instance = value; }
        }

        private UsersDAO()
        {

        }
        //insert
        public bool InsertUser(string tendangnhap, string matkhau, string email, string sdt, int vaitro)
        {
            string query = "INSERT INTO NhanVien( TenDangNhap ,MatKhau ,Email ,Sdt ,VaiTro)"
                + " VALUES  ( @tendangnhap , @matkhau , @email , @sdt , @vaitro )";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { tendangnhap ,matkhau ,email ,sdt ,vaitro }) > 0;
        }
        //delete
        public bool DeleteUserByID(int id)
        {
            string query = "delete from NhanVien where id = @id ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id }) > 0;
        }

        public DataTable GetAllUser()
        {
            string query = "SELECT * FROM NhanVien ";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetUserByID(int id)
        {
            string query = "SELECT * FROM NhanVien where id = @id ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id });
        }

        public bool UpdateUserByID(int id, string tendangnhap, string matkhau, string email, string sdt, int vaitro)
        {
            string query = "UPDATE NhanVien SET TenDangNhap = @ten , MatKhau = @matkhau, Email = @email, Sdt = @sdt, Vaitro = @vaitro WHERE Id = @id ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { tendangnhap, matkhau, email, sdt, vaitro, id }) > 0;
        }

        public List<Users> GetAllUserList()
        {
            List<Users> listUser = new List<Users>();
            string query = "select * from NhanVien";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Users users = new Users(item);
                listUser.Add(users);
            }


            return listUser;

        }
        //login
        public DataRow Login(string username, string password, int role)
        {
            string query = "select * from NhanVien WHERE TenDangNhap = @username and MatKhau = @password and VaiTro = @role";
            if (DataProvider.Instance.ExecuteQuery(query, new object[] { username, password, role }).Rows.Count == 1)
                return DataProvider.Instance.ExecuteQuery(query, new object[] { username, password, role }).Rows[0];
            return null;
        }
    }
}
