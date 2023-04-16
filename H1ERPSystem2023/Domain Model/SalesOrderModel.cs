using H1ERPSystem2023.Databasefiles;

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
                foreach (CustomerModel customer in Database.Instance.GetCuStomersList())
                {
                    //returns the customers name, if the this.CustomerId matches the customerid
                    if (this.CustomerID == customer.CustomerNumber)
                    {
                        return customer.FullName;
                    }
                }

                return null;
            }
        }

        public Condition Condition { get; set; }
        public List<OrderLineModel> OrderLines { get; }

        public decimal Amount
        {
            get => sum();
        }

        /// <summary>
        /// Gives a sum of Product
        /// </summary>
        /// <returns>The sum of all the product chosen</returns>

        #region Constructors

        public SalesOrderModel()
        {
            //used to create a sale order, with no data
        }

        public SalesOrderModel(int orderNumber, string customerId, Condition condition, List<OrderLineModel> orderLines)
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
            decimal sum = 0;
            foreach (OrderLineModel line in OrderLines)
            {
                sum = sum + line.Product.SalePrice;
            }

            return sum;
        }
    }
}