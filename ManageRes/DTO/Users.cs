using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageRes
{
    class Users
    {
        private int id;

        private int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string username;

        private string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string password;

        private string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string email;

        private string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string phone;

        private string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        private int role;

        private int Role
        {
            get { return role; }
            set { role = value; }
        }

        public Users() { }

        public Users(int id, string username, string password, string email, string phone, int role)
        {
            this.Id = id;
            this.Username = username;
            this.Password = password;
            this.Email = email;
            this.Phone = phone;
            this.Role = role;
        }


        public Users(DataRow row)
        {
            this.Id = Convert.ToInt32(row["Id"]);
            this.Username = row["TenDangNhap"].ToString();
            this.Password = (row["MatKhau"]).ToString();
            this.Email =(row["Email"]).ToString();
            this.Phone = (row["Sdt"]).ToString();
            this.Role = Convert.ToInt32(row["VaiTro"]);

        }
    }
}
