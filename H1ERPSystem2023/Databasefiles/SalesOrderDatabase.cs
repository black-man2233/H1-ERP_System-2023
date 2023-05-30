using System.Data.SqlClient;
using H1ERPSystem2023.DomainModel;

namespace H1ERPSystem2023.Databasefiles
{
    public partial class Database
    {
        private List<SalesOrderModel> salesOrders = new();

        /// <summary>
        /// Adds temporary random sales orders
        /// </summary>
        private void _addSalesOrders(SqlConnection connection)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM dbo.SaleOrder", connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    double salePrice = (double)reader.GetDecimal(3);
                    double buyPrice = (double)reader.GetDecimal(4);
                    float storageAmount = (float)reader.GetDouble(6);
                    double avance = (double)reader.GetDecimal(7);

                    ProductModel product = new ProductModel
                    {
                        ID = reader.GetInt32(0),
                        ProductName = reader.GetString(1),
                        Description = reader.GetString(2),
                        Location = reader.GetString(5),
                        SalePrice = salePrice,
                        BuyPrice = buyPrice,
                        StorageAmount = storageAmount,
                        Avance = avance
                    };

                    Products.Add(product);
                }

                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Console.WriteLine(
                    $"Something went wrong while trying to retrieve Products from the database \n {e.Message}");
            }

            salesOrders.Add(new SalesOrderModel());
        }

        public SalesOrderModel GetSalesOrder(int orderNumber)
        {
            foreach (SalesOrderModel salesOrder in salesOrders)
            {
                if (salesOrder.OrderNumber == orderNumber)
                {
                    return salesOrder;
                }
            }

            //If the ID given doesn't exist, the return is "ID doesn't exist" and null, otherwise it would give issues 
            Console.WriteLine("Id findes Ikke");
            return null!;
        }

        /// <summary>
        /// Runs down the whole list and returns it
        /// </summary>
        /// <returns>The whole list of "SaleOrders"</returns>
        public List<SalesOrderModel> GetAllSalesOrder()
        {
            List<SalesOrderModel> _allOrders = new();

            foreach (SalesOrderModel Order in salesOrders)
            {
                _allOrders.Add(Order);
            }

            return _allOrders;

            // SQL Connection thing -> SqlConnection SQLConn = getConnection(); <- touch at a later time
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
                salesOrder.Condition = updateOrder.Condition;
            }
        }

        /// <summary>
        /// Deletes a Order in the SaleOrder list, with the assigned ID
        /// </summary>
        /// <param name="ID">The ID of the Order you want to delete</param>
        public void RemoveSaleOrder(int ID)
        {
            foreach (SalesOrderModel saleOrder in salesOrders)
            {
                if (saleOrder.OrderNumber == ID)
                {
                    salesOrders.Remove(saleOrder);
                    break;
                }
            }
        }
    }
}