using H1ERPSystem2023.Databasefiles;
using H1ERPSystem2023.DomainModel;
using TECHCOOL.UI;

namespace H1ERPSystem2023
{
    public class ProductDetailScreen : Screen
    {
        public override string Title { get; set; } = "Product";

        protected override void Draw()
        {
            Clear(this);

            ListPage<ProductModel> prodList = new();

            //Loops through the Product Database and matches the ID with the selected product ID
            for (int i = 0; i < Database.Instance.Products.Count; i++)
                if (Database.Instance.Products[i].ID == ProductListScreen.SelectedProduct.ID)
                    prodList.Add(Database.Instance.Products[i]);

            prodList.AddColumn("Product ID", "ID");
            prodList.AddColumn("Name", "ProductName");
            prodList.AddColumn("Description", "Description");
            prodList.AddColumn("Price To Buy", "BuyPrice");
            prodList.AddColumn("Price To Sell", "SellPrice");
            prodList.AddColumn("Location", "Location");
            prodList.AddColumn("Storage Amount", "StorageAmount");
            prodList.AddColumn("Measure Unit", "Measure");
            prodList.AddColumn("Avance in %", "AvancePercent");
            prodList.AddColumn("Avance in kr", "Avance");

            prodList.Draw();
        }
    }
}
