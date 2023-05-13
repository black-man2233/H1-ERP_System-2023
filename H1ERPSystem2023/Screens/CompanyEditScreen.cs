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


        void Create()
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
            Clear(this);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press ESC twice to exit");
            Console.ForegroundColor = ConsoleColor.White;

            if (IsCreate)
            {
                Create();
                Database.Instance.AddCompany(Company);
            }
            else
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
                Database.Instance.UpdateCompany(Company.ID.ToString(), Company.CompanyName, Company.Street, Company.StreetNumber, Company.PostalCode, Company.City, Company.Country);
            }
        }
    }
}
