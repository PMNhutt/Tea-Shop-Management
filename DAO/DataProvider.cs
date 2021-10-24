using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShopManagement.DAO
{
    public class DataProvider
    {
        //singleton
        //để chỉ có 1 cái dataprovider trong app thôi, tránh xuất hiện nhiều dataprovider quá mỗi khi
        //kết nối csdl

        //xài thì : DataProvider.Instance.Ex...
        private static DataProvider instance;

        public static DataProvider Instance 
        {
            //get => instance == null ? instance = new DataProvider():instance;
            //private set => instance = value;
            
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; } 
        }

        private DataProvider()
        {

        }
        

        private string connStr = "Data Source=MSI;Initial Catalog=TeaShopManagement;Integrated Security=True";   

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {

            DataTable data = new DataTable();
            //using: khi kết thúc khối lệnh sẽ tự giải phóng bộ nhớ
            using (SqlConnection conn = new SqlConnection(connStr))
            {                   
            SqlCommand com = new SqlCommand(query, conn);
            //add n parameter
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            com.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }


            //trung gian thực hiện câu truy vấn với db
            SqlDataAdapter adapter = new SqlDataAdapter(com);

            //đổ data vào dataTable
            adapter.Fill(data);

            conn.Close();
            }
            return data;
        }

        //trả về số dòng thực hiện thành công(để chạy mấy cái insert, update)
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            
            int data = 0;
            
            //using: khi kết thúc khối lệnh sẽ tự giải phóng bộ nhớ
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand com = new SqlCommand(query, conn);
                //add n parameter
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            com.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = com.ExecuteNonQuery();

                conn.Close();
            }
            return data;
        }

        //trả về số lượng của 1 cái data nào đó
        public object ExecuteScalar(string query, object[] parameter = null)
        {

            object data = 0;
            //using: khi kết thúc khối lệnh sẽ tự giải phóng bộ nhớ
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand com = new SqlCommand(query, conn);
                //add n parameter
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            com.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = com.ExecuteScalar();

                conn.Close();
            }
            return data;
        }

        //login bruh...??????
        public DataTable LoginExecuteQuery(string username, string password,object[] parameter = null)
        {
            string query = "select * from tblAccount where userName =@username and password =@password";
            DataTable data = new DataTable();
            //using: khi kết thúc khối lệnh sẽ tự giải phóng bộ nhớ
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand com = new SqlCommand(query, conn);
                com.Parameters.AddWithValue("@username", username);
                com.Parameters.AddWithValue("@password", password);

                /*
                //add n parameter
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            com.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                */

                //trung gian thực hiện câu truy vấn với db
                SqlDataAdapter adapter = new SqlDataAdapter(com);

                //đổ data vào dataTable
                adapter.Fill(data);

                conn.Close();
            }
            return data;
        }
    }
}
