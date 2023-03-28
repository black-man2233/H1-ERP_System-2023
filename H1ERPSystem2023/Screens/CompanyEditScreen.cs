using H1ERPSystem2023.Databasefiles;
using H1ERPSystem2023.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TECHCOOL.UI;

namespace H1ERPSystem2023.Screens
{
    public class CompanyEditScreen : Screen
    {
        public override string Title { get; set; } = "Edit Company";

        protected override void Draw()
        {
            //CompanyModel compModel = new CompanyModel(1, "Virksomhed", "Vejej", "Nummer", "9900", "Aalborg,", "Denmark", Currency.DKK);
            //Delete above and use the Company Database so data is more consistent
            CompanyDatabase compDB = new();

            Form <CompanyModel> editor = new();

            editor.TextBox("Company Name", "CompanyName");
            editor.TextBox("2", "CompanyName");

            //editor.Edit(compModel);
            //Use Company Database ^
        }
    }
}
