using H1ERPSystem2023.Databasefiles;
using H1ERPSystem2023.DomainModel;
using TECHCOOL.UI;

namespace H1ERPSystem2023.Screens
{
    public class ProductEditScreen : Screen
    {

        public override string Title { get; set; } = "Edit Product";
        public ProductModel Product { get; set; } = new();

        public ProductEditScreen(Object? O)
        {
            if (O is ProductModel product)
                this.Product = new(product);
        }

        public bool IsCreate { get; set; }
        public ProductEditScreen()
        {
            IsCreate = true;
        }


        ProductModel Create()
        {
            Form<ProductModel> editor = new();
            ProductModel newModel = new();

            editor.IntBox("Product ID", "ID");
            editor.TextBox("Name", "ProductName");
            editor.TextBox("Description", "Description");
            editor.IntBox("Price To Buy", "BuyPrice");
            editor.IntBox("Price To Sell", "SellPrice");
            editor.TextBox("Location", "Location");
            editor.IntBox("Storage Amount", "StorageAmount");
            editor.TextBox("Measure Unit", "Measure");

            editor.Edit(newModel);
            return newModel;
        }

        protected override void Draw()
        {
            if (IsCreate)
            {
                Database.Instance.AddProduct(Create());
            }
            else
            {
                Clear(this);

                Form<ProductModel> editor = new();

                editor.IntBox("Product ID", "ID");
                editor.TextBox("Name", "ProductName");
                editor.TextBox("Description", "Description");
                editor.IntBox("Price To Buy", "BuyPrice");
                editor.IntBox("Price To Sell", "SellPrice");
                editor.TextBox("Location", "Location");
                editor.IntBox("Storage Amount", "StorageAmount");
                editor.TextBox("Measure Unit", "Measure");

                editor.Edit(Product);
                Database.Instance.UpdateProduct(Product.ID, Product.ProductName, Product.Description, Product.SellPrice, Product.BuyPrice, Product.Location, Product.StorageAmount, Product.Measure);
            }
        }
    }
}
