using H1ERPSystem2023.Domain_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1ERPSystem2023.Databasefiles
{
    public partial class Database
    {
        static List<SalesOrder> _salesOrders = new List<SalesOrder>();

        public List<SalesOrder> GetSalesOrder()
        {
            return _salesOrders;
        }
        public SalesOrder GetOrderID(int ID)
        {
            foreach (SalesOrder saleOrder in _salesOrders)
            {
                if (saleOrder.OrderNumber == ID)
                {
                    return saleOrder;
                }
            }
            return null;
        }

        public void AddSaleOrder(SalesOrder salesOrder)
        {
            if (salesOrder != null)
            {
                _salesOrders.Add(salesOrder);
            }
        }

        public void UpdateSalesOrders(SalesOrder updateOrder)
        {
            SalesOrder salesOrder = GetOrderID(updateOrder.OrderNumber);
            if (salesOrder != null)
            {
                salesOrder.CreationDate = updateOrder.CreationDate;
                salesOrder.CompleteDate = updateOrder.CompleteDate;
                salesOrder.CustomerID = updateOrder.CustomerID;
                salesOrder.Condition = updateOrder.Condition;
            }

        }
        public void DeleteSaleOrder(int ID)
        {
            foreach (SalesOrder saleOrder in _salesOrders)
            {
                if (saleOrder.OrderNumber == ID)
                {
                    _salesOrders.Remove(saleOrder);
                }
            }
        }

    }
}
