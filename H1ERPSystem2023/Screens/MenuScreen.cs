using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            menu.Start(this);
        }
    }
}
