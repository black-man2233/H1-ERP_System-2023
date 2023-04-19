using H1ERPSystem2023.DomainModel;
using TECHCOOL.UI;

namespace H1_ERP_System_2023.Screens;

public class SaleOrderDetailScreen : Screen
{
    public override string Title { get; set; } = "Sale Order Detail";

    public SalesOrderModel SaleOrder { get; set; }
    
    public SaleOrderDetailScreen(SalesOrderModel salesOrder)
    {
        this.SaleOrder = new(salesOrder);
    }
    
    protected override void Draw()
    {
        //Make sure to put in loop so user can always select
        do
        {
            //Clear the screen at the start to avoid other text
            Clear(this);

            ListPage<SalesOrderModel?> salesOrderList = new();
            
            // foreach (SalesOrderModel saleOrder in Database.Instance.GetSalesOrder()) salesOrderList.Add(saleOrder);
            
            
            salesOrderList.AddColumn("Order Number", "OrderNumber");
            salesOrderList.AddColumn("Date", "CreationDate");
            salesOrderList.AddColumn("Customer Number", "CustomerID");
            salesOrderList.AddColumn("Customer Name", "CustomerName");
            
        } while (Show);
    }
}