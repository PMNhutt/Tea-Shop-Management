using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShopManagement.DTO
{


    public class Menu
    {
        private string foodName;
        private int count;
        private float totalPrice;
        private float price;

        public string FoodName { get => foodName; set => foodName = value; }
        public int Count { get => count; set => count = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
        public float Price { get => price; set => price = value; }

        public Menu(string foodName, int count, float totalPrice, float price)
        {
            this.FoodName = foodName;
            this.Count = count;
            this.TotalPrice = totalPrice;
            this.Price = price;
        }

        public Menu(DataRow row)
        {
            this.FoodName = row["name"].ToString();
            this.Count = (int)row["count"];
            this.TotalPrice = (float)Convert.ToDouble(row["totalPrice"].ToString());
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
        }
    }
}
