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
        private string fullName;
        private string address;
        private DateTime birthDay;      
        private Image image;
       
        public UserInfo()
        { }

        public UserInfo(DataRow row)
        {
            this.Id = (int)row["Id"];
            this.UserId = (int)row["IdNhanVien"];            
            this.FullName = row["HoTen"].ToString();
            this.BirthDay = (DateTime)row["NgaySinh"];
            this.Address = row["DiaChi"].ToString();           
            if (row["HinhAnh"].ToString() != "")
            {
                Byte[] pic = (byte[])row["HinhAnh"];
                MemoryStream picture = new MemoryStream(pic);
                this.image = Image.FromStream(picture);
            }
           

        }

        public int ID { get => Id; set => Id = value; }
        public int UserId { get => userId; set => userId = value; }
        public string FullName { get => fullName; set => fullName = value; }     
        public DateTime BirthDay { get => birthDay; set => birthDay = value; }
        public string Address { get => address; set => address = value; }        
        public Image Image { get => image; set => image = value; }
       
    }
}
