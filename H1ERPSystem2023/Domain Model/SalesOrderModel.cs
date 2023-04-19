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
        public DateTime CompleteDate { get; set; }
        public int CustomerID { get; set; }
        public Condition Condition { get; set; }
        public List<OrderLineModel> OrderLines { get; }

        /// <summary>
        /// Gives a sum of Product
        /// </summary>
        /// <returns>The sum of all the product chosen</returns>
        public double Sum()
        {
            double sum = 0;
            foreach (OrderLineModel line in OrderLines)
            {
                sum += line.Product.SalePrice;
            }

            return sum;
        }
    }
}