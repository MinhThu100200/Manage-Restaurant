using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageRes
{
    class UserInfoDAO
    {
        private static UserInfoDAO instance;

        public static UserInfoDAO Instance
        {
            get { if (instance == null) instance = new UserInfoDAO(); return instance; }
            private set { instance = value; }
        }

        private UserInfoDAO()
        {

        }

        public bool InsertUserInfo(int idnhanvien, string hoten, string diachi, DateTime ngaysinh, MemoryStream hinhanh)
        {
            string query = "INSERT INTO ThongTinChiTiet( IdNhanVien , HoTen, DiaChi, NgaySinh, HinhAnh)"
                + " VALUES  ( @tendangnhap , @matkhau, @email, @sdt, @vaitro )";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { idnhanvien, hoten, diachi, ngaysinh, hinhanh.ToArray() }) > 0;
        }

        public bool DeleteUserInfoByID(int id)
        {
            string query = "delete from ThongTinChiTiet where id = @id ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id }) > 0;
        }

        public DataTable GetAllUserInfo()
        {
            string query = "SELECT * FROM ThongTinChiTiet ";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetUserInfoByID(int id)
        {
            string query = "SELECT * FROM ThongTinChiTiet where id = @id ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id });
        }

        public bool UpdateUserInfoByID(int id, int idnhanvien, string hoten, string diachi, DateTime ngaysinh, MemoryStream hinhanh)
        {
            string query = "UPDATE ThongTinChiTiet SET IdNhanVien = @idnhanvien , HoTen = @hoten, DiaChi = @diachi, NgaySinh = @ngaysinh, HinhAnh = @hinhanh WHERE Id = @id ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { idnhanvien, hoten, diachi, ngaysinh, hinhanh.ToArray(), id }) > 0;
        }

        public List<UserInfo> GetAllUserInfoList()
        {
            List<UserInfo> listUserInfo = new List<UserInfo>();
            string query = "select * from ThongTinChiTiet";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                UserInfo userinfo = new UserInfo(item);
                listUserInfo.Add(userinfo);
            }


            return listUserInfo;

        }
    }
}
