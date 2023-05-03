
using H1_ERP_System_2023.Screens;
using H1ERPSystem2023.Databasefiles;

#pragma warning disable
using Org.BouncyCastle.Asn1.Mozilla;

namespace H1ERPSystem2023.DomainModel
{
    public enum Condition
    {
        None,
        Created,
        Confirmed,
        Packed,
        Done
    }

    public class SalesOrderModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int OrderNumber { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? CompleteDate { get; set; }
        public string CustomerID { get; set; }


        public string CustomerName { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string PhoneNumbers { get; set; }
        public string EmailAddress { get; set; }

        public Condition Condition { get; set; }
        public List<OrderLineModel>? OrderLines { get; }

        public decimal Amount
        {
            get => sum();
        }

        // <summary>
        // Gives a sum of Product
        // </summary>
        // <returns>The sum of all the product chosen</returns>

        #region Constructors

        public SalesOrderModel(SalesOrderModel salesOrder)
        {
            this.OrderNumber = salesOrder.OrderNumber;
            this.CreationDate = salesOrder.CreationDate;
            this.CompleteDate = salesOrder.CompleteDate;
            this.CustomerID = salesOrder.CustomerID;
            this.Condition = salesOrder.Condition;
            this.OrderLines = salesOrder.OrderLines;
        }

        public SalesOrderModel(int orderNumber, string customerId, Condition condition,
            List<OrderLineModel>? orderLines)
        {
            this.OrderNumber = orderNumber;
            this.CreationDate = DateTime.Today;
            this.CompleteDate = null;
            this.CustomerID = customerId;
            this.Condition = condition;
            this.OrderLines = orderLines;
        }

        public SalesOrderModel()
        {
        }

        #endregion

        private decimal sum()
        {
            if (OrderLines is not null)
            {
                decimal sum = 0;
                foreach (OrderLineModel line in OrderLines)
                {
                    sum += line.Product.SellPrice;
                }

                return sum;

            }

            //returns 0 if the Orderlines is either empty or null
            return 0;
        }
    }
}