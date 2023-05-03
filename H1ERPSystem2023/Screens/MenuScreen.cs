using H1_ERP_System_2023.Screens;
using TECHCOOL.UI;

namespace H1ERPSystem2023.Screens
{
    public class MenuScreen : Screen
    {
        public override string Title { get; set; } = "LNE Security A/S ";

        protected override void Draw()
        {
            Clear(this);

            Menu menu = new();

            menu.Add(new CompaniesListScreen());
            menu.Add(new ProductListScreen());
            menu.Add(new CustomerListScreen());
            menu.Add(new SalesOrderHeadersScreen());

            menu.Start(this);
        }
    }
}
