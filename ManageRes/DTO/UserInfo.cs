using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageRes
{
    class UserInfo
    {
        private int Id;
        private int userId;
        private string firstName;
        private string lastName;
        private DateTime birthDay;
        private string address;
        private Image image;
        private string phone;
       
        public UserInfo()
        { }

        public UserInfo(DataRow row)
        {
            this.Id = (int)row["ID"];
            this.UserId = (int)row["ID User"];            
            this.FirstName = row["FirstName"].ToString();
            this.LastName = row["LastName"].ToString();
            this.birthDay = (DateTime)row["BirthDay"];
            this.Address = row["Address"].ToString();           
            if (row["Image"].ToString() != "")
            {
                Byte[] pic = (byte[])row["Image"];
                MemoryStream picture = new MemoryStream(pic);
                this.image = Image.FromStream(picture);
            }
            this.Phone = row["Phone"].ToString();

        }

        public int ID { get => Id; set => Id = value; }
        public int UserId { get => userId; set => userId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime BirthDay { get => birthDay; set => birthDay = value; }
        public string Address { get => address; set => address = value; }        
        public Image Image { get => image; set => image = value; }
        public string Phone { get => phone; set => phone = value; }
    }
}
