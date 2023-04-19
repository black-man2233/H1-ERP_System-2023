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
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Road { get; set; }
        public string HouseNumber { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }


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