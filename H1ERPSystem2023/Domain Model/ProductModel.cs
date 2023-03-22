using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_ERP_System_2023.Domain_Model
{
    public class ProductModel
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Saleprice { get; set; }
        public int BuyPrice { get; set; }
        public string Location { get; set; } // nummer på 4 bogstaver, 
        public int Quantity { get; set; }
        public string Measure { get; set; }


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
