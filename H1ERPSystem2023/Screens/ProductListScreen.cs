using H1ERPSystem2023.Databasefiles;
using H1ERPSystem2023.DomainModel;
using H1ERPSystem2023.Screens;
using TECHCOOL.UI;
#pragma warning disable
namespace H1ERPSystem2023
{
    public class ProductListScreen : Screen
    {
        public override string Title { get; set; } = "Product List";

        //Made it a static field so it's accessible from the detail screen without instanciating
        public static ProductModel SelectedProduct;

        protected override void Draw()
        {
            //Make sure to put in loop so user can always select
            do
            {
                //Clear the screen at the start to avoid other text
                Clear(this);
                Console.WriteLine("F1 to create a new product");
                Console.WriteLine("F2 to edit a exiting product");

                ListPage<ProductModel> prodList = new();

                foreach (ProductModel prodModel in Database.Instance.GetAllProductModels())
                    prodList.Add(prodModel);    

                prodList.AddColumn("Product ID", "ID");
                prodList.AddColumn("Name", "ProductName");
                prodList.AddColumn("Storage Amount", "StorageAmount");
                prodList.AddColumn("Price To Buy", "BuyPrice");
                prodList.AddColumn("Price To Sell", "SellPrice");
                prodList.AddColumn("Avance in %", "AvancePercent");

                prodList.AddKey(ConsoleKey.F1, NewProd);
                prodList.AddKey(ConsoleKey.F2, Edit);
                //Gives the user the option to Select between the products when called, make sure to check for not null. That will tell it's been selected with enter
                SelectedProduct = prodList.Select();
                if (SelectedProduct != null)
                    Screen.Display(new ProductDetailScreen());
                else
                { Quit(); return; }
                prodList.Draw();

            } while (Show);

        }
        void Edit(ProductModel _input)
        {
            if (_input is ProductModel product)
                Screen.Display(new ProductEditScreen(product));
        }
        void NewProd(Object O)
        {
            Display(new ProductEditScreen());
        }
    }
}
