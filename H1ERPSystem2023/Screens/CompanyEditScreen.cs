using H1ERPSystem2023.Databasefiles;
using H1ERPSystem2023.DomainModel;
using TECHCOOL.UI;

namespace H1ERPSystem2023.Screens
{
    public class CompanyEditScreen : Screen
    {

        public override string Title { get; set; } = "Edit Company";
        public CompanyModel Company { get; set; } = new();

        public CompanyEditScreen(Object? O)
        {
            if (O is CompanyModel company)
                this.Company = new(company);
        }

        public bool IsCreate { get; set; }
        public CompanyEditScreen()
        {
            IsCreate = true;
        }


        void create()
        {
            Form<CompanyModel> editor = new();

            editor.TextBox("Company Name", "CompanyName");
            editor.TextBox("Street", "Street");
            editor.IntBox("StreetNumber", "StreetNumber");
            editor.IntBox("PostalCode", "PostalCode");
            editor.TextBox("City", "City");
            editor.TextBox("Country", "Country");
            editor.TextBox("Currency", "Currency");



            editor.Edit(Company);
        }

        protected override void Draw()
        {
            if (IsCreate)
            {
                create();
                Database.Instance.AddCompany(Company);
            }
            else
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
                editor.IntBox("StreetNumber", "StreetNumber");
                editor.IntBox("PostalCode", "PostalCode");
                editor.TextBox("City", "City");
                editor.TextBox("Country", "Country");
                editor.TextBox("Currency", "Currency");




                editor.Edit(Company);
                Database.Instance.UpdateCompany(Company.ID, Company.CompanyName, Company.Street, Company.StreetNumber, Company.PostalCode, Company.City, Company.Country);

            }
        }
    }
}
