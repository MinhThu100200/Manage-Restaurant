using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageRes
{
    class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return instance; }
            private set { instance = value; }
        }

        private FoodDAO()
        {

        }

        public bool InsertFood(string ten, double gia)
        {
            string query = "INSERT INTO Mon( ten ,gia )"
                + " VALUES  ( @ten , @gia )";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] {ten, gia}) > 0;
        }

        public bool CheckFoodName(string ten)
        {
            string query = "Select * from Mon where ten = @ten";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { ten }).Rows.Count > 0;
        }

        public bool CheckFoodID(int id)
        {
            string query = "Select * from Mon where id = @id";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id }).Rows.Count > 0;
        }

        public bool DeleteFoodByID(int id)
        {
            string query = "delete from Mon where id = @id ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id }) > 0;
        }

        public DataTable GetAllFood()
        {
            string query = "SELECT * FROM Mon ";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetFoodByID(int id)
        {
            string query = "SELECT * FROM Mon where id = @id ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id });
        }

        public bool UpdateFoodByID(int id, string ten, double gia)
        {
            string query = "UPDATE Mon SET Ten = @ten , Gia = @gia WHERE Id = @id ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ten, gia, id}) > 0;
        }

        public List<Food> GetAllCourseList()
        {
            List<Food> listFood = new List<Food>();
            string query = "select * from Food";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                listFood.Add(food);
            }


            return listFood;

        }
    }
}
