using H1ERPSystem2023.DomainModel;
using TECHCOOL.UI;

namespace H1_ERP_System_2023.Screens;
#pragma warning disable
/// <summary>
/// This screen displays the details of the selected SaleOrder from the Header
/// </summary>
public class SaleOrderDetailScreen : Screen
{
    public override string Title { get; set; } = "Sale Order Detail";

    private SalesOrderModel saleOrder { get; set; }

    public SaleOrderDetailScreen() { }

    public SaleOrderDetailScreen(SalesOrderModel salesOrder)
    {
        this.saleOrder = new(salesOrder);
    }

    protected override void Draw()
    {
        {
            //Clear the screen at the start to avoid other text
            Clear(this);

            ListPage<DetailScreenModel> OrderDetail = new();
            OrderDetail.Add(new DetailScreenModel($"Creation Date : {saleOrder.CreationDate}"));
            OrderDetail.Add(new DetailScreenModel($"Completed Date : {saleOrder.CompleteDate}"));
            OrderDetail.Add(new DetailScreenModel($"Costumer Number : {saleOrder.OrderCustomer.PersonID}"));
            OrderDetail.Add(new DetailScreenModel($"Costumer Name : {saleOrder.CustomerName}"));

            OrderDetail.AddColumn($"Order Number : {saleOrder.OrderNumber} ", "Title"); //Add column to the list

            OrderDetail.Draw();

        }
    }
}