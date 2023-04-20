
using H1ERPSystem2023.Databasefiles;

#pragma warning disable
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
        public int OrderNumber { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? CompleteDate { get; set; }
        public string CustomerID { get; set; }

        public string CustomerName
        {
            get
            {
                //Loops through all the customers
                foreach (CustomerModel customer in Database.Instance.GetAllCustomerModels())
                {
                    //returns the customers name, if the this.CustomerId matches the customerid
                    if (this.CustomerID == customer.PersonID)
                    {
                        return customer.FullName;
                    }
                }

                return null!;
            }
        }

        public Condition Condition { get; set; }
        public List<OrderLineModel>? OrderLines { get; }

        public decimal Amount
        {
            get => sum();
        }

        /// <summary>
        /// Gives a sum of Product
        /// </summary>
        /// <returns>The sum of all the product chosen</returns>

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