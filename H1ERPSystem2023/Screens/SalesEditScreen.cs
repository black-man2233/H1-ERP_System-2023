using H1ERPSystem2023.Databasefiles;
using H1ERPSystem2023.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TECHCOOL.UI;

namespace H1ERPSystem2023.Screens
{
    public class SalesEditScreen : Screen
    {
        public override string Title { get; set; } = "Edit Sales";

        protected override void Draw()
        {
            Clear(this);
            ListPage<SalesOrderModel> SalesList = new();
           foreach (SalesOrderModel SalesModel in Database.Instance.SalesOrders)
                SalesList.Add(SalesModel);
        }
    }
}
