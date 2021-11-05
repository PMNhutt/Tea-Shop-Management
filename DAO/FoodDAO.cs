using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShopManagement.DTO;

namespace TeaShopManagement.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            private set { FoodDAO.instance = value; }
        }

        private FoodDAO()
        {

        }

        public List<Food> GetListFoodByCategoryID(int id)
        {
            List<Food> list = new List<Food>();

            string query = "select * from tblFoods where status = 'active' and idCategory = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        public List<Food> GetListFood()
        {
            List<Food> list = new List<Food>();

            string query = "select * from tblFoods where status = 'active'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        public bool AddFood(string name, int idCategory, float price)
        {
            string query = string.Format("insert tblFoods (name, idCategory, price, status) values (N'{0}', {1}, {2}, 'active')",name,idCategory,price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateFood(int idFood, string name, int idCategory, float price)
        {
            string query = string.Format("update tblFoods set name = '{0}', idCategory = {1}, price = {2} where id = {3}", name, idCategory, price, idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteFood(int idFood)
        {
            string query = string.Format("update tblFoods set status = 'passive' where id = {0}", idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public int GetFoodByName (string name)
        {
            string query = string.Format("select name from tblFoods where name = N'{0}'",name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                return 1;
            }
            return -1;
        }

        public List<Food> SearchFoodByFoodName (string name)
        {
            List<Food> list = new List<Food>();
            //search gan dung name
            string query = string.Format("select * from tblFoods where status = 'active' and name like '%{0}%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        public Food CheckFoodStatusByName (string name)
        {
            string query = string.Format("select * from tblFoods where status = 'passive' and name = '{0}'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food f = new Food(item);
                return f;
            }
            return null;
        }

        public void ChangeFoodStatus(string name)
        {
            string query = string.Format("update tblFoods set status = 'active' where name = '{0}'", name);
            DataProvider.Instance.ExecuteQuery(query);
        }

        public int GetIdFoodByName (string name)
        {
            try
            {
                string query = string.Format("select id from tblFoods where name = '{0}'", name);
                return (int)DataProvider.Instance.ExecuteScalar(query);
            }
            catch
            {
                return 1;
            }
        }
    }
}
