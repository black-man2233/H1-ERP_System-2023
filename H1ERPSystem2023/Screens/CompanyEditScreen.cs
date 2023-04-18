using H1ERPSystem2023.Databasefiles;
using H1ERPSystem2023.DomainModel;
using TECHCOOL.UI;

namespace H1ERPSystem2023.Screens
{
    public class CompanyEditScreen : Screen
    {

        public override string Title { get; set; } = "Edit Company";

        protected override void Draw()
        {
            Clear(this);

            ListPage<CompanyModel> compList = new();
            Form<CompanyModel> editor = new();
            CompanyModel company;

            foreach (CompanyModel compModel in Database.Instance.Companies)
                compList.Add(compModel);
            compList.AddColumn("navn", "CompanyName");
            //compList.AddColumn("");
            company = compList.Select();

            editor.TextBox("Company Name", "CompanyName");
            editor.TextBox("Street", "Street");
            editor.TextBox("StreetNumber", "StreetNumber");
            editor.TextBox("Country", "Country");
            editor.TextBox("Currency", "Currency");




            if (company != null) 
                editor.Edit(company);
            else
            { Quit(); return; }
            Clear(this);
            //Use Company Database ^
        }
    }
}
