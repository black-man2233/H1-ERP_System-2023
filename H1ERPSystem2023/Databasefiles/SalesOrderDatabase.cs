using H1ERPSystem2023.DomainModel;

namespace H1ERPSystem2023.Databasefiles
{
    public partial class Database
    {
       public static List<SalesOrderModel> SalesOrders = new List<SalesOrderModel>();

        /// <summary>
        /// Runs down the whole list and returns it
        /// </summary>
        /// <returns>The whole list of "SaleOrders"</returns>
        public List<SalesOrderModel> GetSalesOrder()
        {
            return SalesOrders;
        }

        /// <summary>
        /// Checkes the given input is an ID from the SaleOrder list
        /// </summary>
        /// <param name="ID">The ID you want to check that has an SaleOrder</param>
        /// <returns>The whole SaleOrder from the given ID</returns>
        public SalesOrderModel GetOrderID(int ID)
        {
            foreach (SalesOrderModel saleOrder in SalesOrders)
            {
                if (saleOrder.OrderNumber == ID)
                {
                    return saleOrder;
                }
            }
            return null!;
        }

        /// <summary>
        /// Add's the given order to the SaleOrder list
        /// </summary>
        /// <param name="salesOrder">The SaleOrder you want to add</param>
        public void AddSaleOrder(SalesOrderModel salesOrder)
        {
            if (salesOrder != null)
            {
                SalesOrders.Add(salesOrder);
            }
        }

        /// <summary>
        /// Updates a already existing SaleOrder, in the list with the new assigned values
        /// </summary>
        /// <param name="updateOrder">The new values for a already existing order</param>
        public void UpdateSalesOrders(SalesOrderModel updateOrder)
        {
            SalesOrderModel salesOrder = GetOrderID(updateOrder.OrderNumber);
            if (salesOrder != null)
            {
                salesOrder.CreationDate = updateOrder.CreationDate;
                salesOrder.CompleteDate = updateOrder.CompleteDate;
                salesOrder.CustomerID = updateOrder.CustomerID;
                salesOrder.Condition = updateOrder.Condition;
            }

        }

        /// <summary>
        /// Deletes a Order in the SaleOrder list, with the assigned ID
        /// </summary>
        /// <param name="ID">The ID of the Order you want to delete</param>
        public void DeleteSaleOrder(int ID)
        {
            foreach (SalesOrderModel saleOrder in SalesOrders)
            {
                if (saleOrder.OrderNumber == ID)
                {
                    SalesOrders.Remove(saleOrder);
                }
            }
        }

    }
}
