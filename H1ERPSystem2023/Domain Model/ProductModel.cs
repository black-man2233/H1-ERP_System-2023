﻿namespace H1ERPSystem2023.DomainModel
{

    public enum Measure { Meter, Liter }
    public class ProductModel
    {

        public int ID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double SellPrice { get; set; }
        public double BuyPrice { get; set; }
        public string Location { get; set; }
        public float StorageAmount { get; set; }
        public double Avance { get; set; }
        public double AvancePercent { get; set; }
        public Measure Measure { get; set; }

        public ProductModel() { }

        public ProductModel(ProductModel product)
        {
            ID = product.ID;
            ProductName = product.ProductName;
            Description = product.Description;
            SellPrice = product.SellPrice;
            BuyPrice = product.BuyPrice;
            Location = product.Location;
            StorageAmount = product.StorageAmount;
            Measure = product.Measure;
            Avance = product.SellPrice - product.BuyPrice;
            //Sell Price - Buy Price is to get the Profit (avance)
            AvancePercent = AvancePercentCalc(product.SellPrice - product.BuyPrice, product.SellPrice);
        }

        public ProductModel(int id, string productName, string description, double sellPrice, double buyPrice, string location, float storageAmount, Measure measure)
        {
            ID = id;
            ProductName = productName;
            Description = description;
            SellPrice = sellPrice;
            BuyPrice = buyPrice;
            Location = location;
            StorageAmount = storageAmount;
            Measure = measure;
            Avance = sellPrice - buyPrice;
            AvancePercent = AvancePercentCalc(sellPrice - buyPrice, sellPrice);
        }

        //Profit * 100 and divided by the price it sold for.
        //We * by 100 first to keep the number above 0 since it's an int.
        public static double AvancePercentCalc(double a, double b) => (a * 100 / b);

        public static double Profit(double a, double b, double c) => ((a + b) * c);



    }
}
