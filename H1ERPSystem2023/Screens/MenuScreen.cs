using TECHCOOL.UI;

namespace H1ERPSystem2023.Screens
{
    public class MenuScreen : Screen
    {
        public override string Title { get; set; } = "Company Menu";

        protected override void Draw()
        {
            Clear(this);

            Menu menu = new();

            menu.Add(new CompaniesListScreen());
            menu.Add(new CompanyEditScreen());
            menu.Add(new CustomerListScreen());
           
            menu.Start(this);
        }
    }
}
