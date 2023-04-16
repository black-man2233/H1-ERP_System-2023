using H1_ERP_System_2023.Screens;
using TECHCOOL.UI;

namespace H1ERPSystem2023.Screens
{
    public class MenuScreen : Screen
    {
        public override string Title { get; set; } = "Compnay Menu";

        protected override void Draw()
        {
            Clear(this);

            Menu menu = new();

            menu.Add(new CompaniesListScreen());
            menu.Add(new CompanyEditScreen());
            menu.Add(new SalesOrderHeadersScreen());
            menu.Add(new SalesOrdreDetailsScreen());

            menu.Start(this);
        }
    }
}