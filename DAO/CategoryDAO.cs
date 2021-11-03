using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShopManagement.DTO;

namespace TeaShopManagement.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance; }
            private set { CategoryDAO.instance = value; }
        }

        private CategoryDAO()
        {

        }

        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();

            string query = "select * from tblCategories where status = 'active'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }

            return list;
        }

        public Category GetCategoryById(int id)
        {
            Category category = null;
            string query = "select * from tblCategories where id = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                category = new Category(item);
                return category;
            }

            return category;
        }

        public Category GetCategoryByName(string name)
        {
            Category category = null;
            string query = string.Format("select * from tblCategories where name = '{0}'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                category = new Category(item);
                return category;
            }

            return category;
        }

        public bool AddCategory(string name)
        {
            string query = string.Format("insert tblCategories (name, status) values ('{0}', 'active')", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool RemoveCategory(string name)
        {
            string query = string.Format("update tblCategories set status = 'passive' where name = '{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateCategory(string name, int id)
        {
            string query = string.Format("update tblCategories set name = '{0}' where id = {1}", name, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public Category CheckExistCategory (string name)
        {
            string query = string.Format("select * from tblCategories where status = 'passive' and name = '{0}'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Category cate = new Category(item);
                return cate;
            }
            return null;
        }

        public void ChangeCategoryStatus(string name)
        {
            string query = string.Format("update tblCategories set status = 'active' where name = '{0}'", name);
            DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
