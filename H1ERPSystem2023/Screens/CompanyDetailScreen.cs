using H1ERPSystem2023.Databasefiles;
using H1ERPSystem2023.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TECHCOOL.UI;

namespace H1ERPSystem2023
{
    public class CompanyDetailScreen : Screen
    {
        public override string Title { get; set; } = "Company";

        protected override void Draw()
        {
            Clear(this);

            ListPage<CompanyModel> compList = new();
            CompanyDatabase compDB = new();

            //Loops through the Company Database and matches the ID with the selected company ID
            for(int i = 0; i < compDB.Companies.Count; i++)
                if(compDB.Companies[i].ID == CompaniesListScreen.SelectedCompany.ID)
                    compList.Add(compDB.Companies[i]);
            

            compList.AddColumn("Name", "CompanyName");
            compList.AddColumn("Street", "Street");
            compList.AddColumn("Street Number", "StreetNumber");
            compList.AddColumn("Postal Code", "PostalCode");
            compList.AddColumn("City", "City");
            compList.AddColumn("Country", "Country");
            compList.AddColumn("Currency", "Currency");


            compList.Draw();
        }
    }
}
