using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace H1ERPSystem2023.Domain_Model
{

    public enum Measure { Meter, Liter }
    public class ProductModel
    {

        public int ID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int SalePrice { get; set; }
        public int BuyPrice { get; set; }
        public string Location { get; set; } // nummer på 4 bogstaver, 
        public int Quantity { get; set; }
        public Measure Measure { get; set; }

        public ProductModel(int id, string productName, string description, int salePrice, int buyPrice, string location, int quantity, Measure measure)
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


        public int Profit(int a, int b, int c, int d)
        {
            a = (b + c) * d;

            return a;
        }
        public int Avance(int a, int b, int c)
        {
            a = b / c * 100;


            return a;

        }





    }
}
