using H1ERPSystem2023.DomainModel;
using TECHCOOL.UI;

namespace H1ERPSystem2023.Screens
{
    public class CompanyEditScreen : Screen
    {

        public override string Title { get; set; } = "Edit Company";
        public CompanyModel Company { get; set; }

        public CompanyEditScreen(CompanyModel company)
        {
            this.Company = new(company);
        }

        protected override void Draw()
        {
            Clear(this);

            Form<CompanyModel> editor = new();
            //ListPage<CompanyModel> compList = new();
            //CompanyModel company;

            //foreach (CompanyModel compModel in Database.Instance.Companies)
            //    compList.Add(compModel);
            //compList.AddColumn("navn", "CompanyName");
            ////compList.AddColumn("");
            //company = compList.Select();

            editor.TextBox("Company Name", "CompanyName");
            editor.TextBox("Street", "Street");
            editor.TextBox("StreetNumber", "StreetNumber");
            editor.TextBox("Country", "Country");
            editor.TextBox("Currency", "Currency");




            editor.Edit(Company);
            Console.ReadLine();
            //Use Company Database ^
        }
    }
}
