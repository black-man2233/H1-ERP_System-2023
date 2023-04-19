using H1ERPSystem2023.Databasefiles;
using H1ERPSystem2023.DomainModel;
using H1ERPSystem2023.Screens;
using TECHCOOL.UI;
namespace H1ERPSystem2023
{
    public class CompaniesListScreen : Screen
    {
        public override string Title { get; set; } = "List of Companies";

        //Made it a static field so it's accessible from the detail screen without instanciating
        public static CompanyModel SelectedCompany;

        protected override void Draw()
        {
            //Make sure to put in loop so user can always select
            do
            {
                //Clear the screen at the start to avoid other text
                Clear(this);
                Console.WriteLine("F1 to create a new company");
                Console.WriteLine("F2 to edit a exiting company");

                ListPage<CompanyModel> compList = new();

                foreach (CompanyModel compModel in Database.Instance.Companies)
                    compList.Add(compModel);

                compList.AddColumn("Name", "CompanyName");
                compList.AddColumn("Country", "Country");
                compList.AddColumn("Currency", "Currency");

                compList.AddKey(ConsoleKey.F1, NewComp);
                compList.AddKey(ConsoleKey.F2, Edit);
                //Gives the user the option to Select between the companies when called, make sure to check for not null. That will tell it's been selected with enter
                SelectedCompany = compList.Select();
                if (SelectedCompany != null)
                    Screen.Display(new CompanyDetailScreen());
                else
                { Quit(); return; }
                compList.Draw();

            } while (Show);

        }
        void Edit(CompanyModel _input)
        {
            if (_input is CompanyModel company)
                Screen.Display(new CompanyEditScreen(company));
        }
        void NewComp(Object O)
        {
            Display(new CompanyEditScreen());
        }
    }
}
