﻿using H1ERPSystem2023.Databasefiles;
using H1ERPSystem2023.Domain_Model;

namespace H1ERPSystem2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Database db = new Database();
            SalesOrder salesOrder = new SalesOrder()
            {
                OrderNumber = 1,
                CreationDate = new DateTime(),
                CompleteDate = new DateTime(),
                CustomerID = 1,
                Condition = Condition.Created
            };
            db.AddSaleOrder(salesOrder);



        }
    }
}