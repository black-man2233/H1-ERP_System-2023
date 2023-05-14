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
                Console.WriteLine("F5 to delete a product");

                ListPage<ProductModel> prodList = new();

                foreach (ProductModel prodModel in Database.Instance.GetAllProductModels())
                    prodList.Add(prodModel);

                prodList.AddColumn("Product ID", "ID");
                prodList.AddColumn("Name", "ProductName");
                prodList.AddColumn("Storage Amount", "StorageAmount");
                prodList.AddColumn("Price To Buy", "BuyPrice");
                prodList.AddColumn("Price To Sell", "SalePrice");
                prodList.AddColumn("Avance in %", "AvancePercent");

                prodList.AddKey(ConsoleKey.F1, NewProd);
                prodList.AddKey(ConsoleKey.F2, Edit);
                prodList.AddKey(ConsoleKey.F5, Delete);
                //Gives the user the option to Select between the products when called, make sure to check for not null. That will tell it's been selected with enter

                try
                {
                    SelectedProduct = prodList.Select();
                    if (SelectedProduct != null)
                        Screen.Display(new ProductDetailScreen());
                    else
                    { Quit(); return; }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Select a row above");
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.ReadLine();
                    Console.Clear();
                    Display(new ProductListScreen());
                    Quit();
                }

                prodList.Draw();
            } while (Show);

        }
        void Edit(ProductModel input)
        {
            Display(new ProductEditScreen(input));
        }
        void NewProd(Object O)
        {
            Display(new ProductEditScreen());
        }
        void Delete(ProductModel input)
        {
            Database.Instance.RemoveProduct(input.ID);
            Draw();
        }
    }
}
