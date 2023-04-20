using H1ERPSystem2023.DomainModel;

namespace H1ERPSystem2023.Databasefiles
{
    public partial class Database
    {
        private List<SalesOrderModel> salesOrders = new();

        /// <summary>
        /// Adds temporary random sales orders
        /// </summary>
        private void _addSalesOrders()
        {
            for (int i = 0; i < 5; i++)
            {
                //random Orderid
                Random random = new Random();
                int randomOrderId = random.Next();

                //random Orderid
                int randomCustommerId = random.Next(1, 3);

                //orderlines list
                List<OrderLineModel> orderLines = new();
                for (int j = 0; j < Instance.Products.Count - 1; j++)
                {
                    orderLines.Add(new(Instance.Products[j]));
                }

                // adds the randomised data to salesordersList
                salesOrders.Add(new SalesOrderModel(randomOrderId, $"{randomCustommerId}", Condition.Done, orderLines));
            }
        }

        /// <summary>
        /// Runs down the whole list and returns it
        /// </summary>
        /// <returns>The whole list of "SaleOrders"</returns>
        public List<SalesOrderModel> GetSalesOrder()
        {
            return salesOrders;
        }

        /// <summary>
        /// Checkes the given input is an ID from the SaleOrder list
        /// </summary>
        /// <param name="ID">The ID you want to check that has an SaleOrder</param>
        /// <returns>The whole SaleOrder from the given ID</returns>
        public SalesOrderModel GetOrderID(int ID)
        {
            foreach (SalesOrderModel saleOrder in salesOrders)
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
                salesOrders.Add(salesOrder);
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
            foreach (SalesOrderModel saleOrder in salesOrders)
            {
                if (saleOrder.OrderNumber == ID)
                {
                    salesOrders.Remove(saleOrder);
                }
            }
        }
    }
}
