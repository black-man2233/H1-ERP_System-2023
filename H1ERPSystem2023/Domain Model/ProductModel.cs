using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_ERP_System_2023.Domain_Model
{
    public class ProductModel
    {

        public int ID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int SalePrice { get; set; }
        public int BuyPrice { get; set; }
        public string Location { get; set; } // nummer på 4 bogstaver, 
        public int Quantity { get; set; }
        public string Measure { get; set; }

        public ProductModel(int id, string productName, string description, int salePrice, int buyPrice, string location, int quantity, string measure)
        {
            ID = id;
            ProductName = productName;
            Description = description;
            SalePrice = salePrice;
            BuyPrice = buyPrice;
            Location = location;
            Quantity = quantity;
            Measure = measure;
        }


        static int Profit(int a, int b, int c, int d)
        {
            a = (b + c) * d;

            return a;
        }
        static int Avance(int a, int b, int c)
        {
            a = b / c * 100;


            return a;

        }





    }
}
