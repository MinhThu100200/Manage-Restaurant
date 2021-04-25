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
        private int Id;
        private string Username;
        private string Password;
        private string email;
        private int role;

        public Users()
        { }

        public Users(DataRow row)
        {
            this.Id = (int)row["ID"];
            this.Username = row["Username"].ToString();
            this.Password = row["Password"].ToString();
            this.email = row["Email"].ToString();           
            this.role = (int)row["Role"];
           
        }
        public int ID { get => ID; set => ID = value; }
        public string UserName { get => Username; set => Username = value; }
        public string PassWord { get => Password; set => Password = value; }       
        public string Email { get => email; set => email = value; }
        public int Role { get => role; set => role = value; }
    }
}
