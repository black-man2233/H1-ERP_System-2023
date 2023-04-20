using H1ERPSystem2023.DomainModel;

namespace H1ERPSystem2023.Databasefiles
{
    public partial class Database
    {
        public List<ProductModel> Products = new List<ProductModel>();


        //AddProduct uses the product List above, and gives us 2 products to work with along with a lot of information
        //about them
        void _addProducts()
        {
            Products.Add(new ProductModel(1, "Nesquick", "Chokolade Poo", 26, 18, "AFRIKA", 265.6f, Measure.Liter));

            Products.Add(new ProductModel(2, "BlackBeans", "BLACKMAN", 200, 18, "CONGO,", 108.2f, Measure.Meter));
        }

        // GetProduct gets an ID i program.cs (by the user), and uses that with the foreach to take all companies
        //and check whichever one has a matching ID, so it can return the information.

        public ProductModel GetProduct(int ID)
        {
            foreach (ProductModel product in Products)
            {
                if (product.ID == ID)
                {
                    return product;
                }
            }

            //If the ID given doesn't exist, the return is "ID doesn't exist" and null, otherwise it would give issues 
            Console.WriteLine("ID findes Ikke");
            return null!;
        }

        // GetAllProductModels Uses a foreach to take all products, and _AllProducts is used to display said companies. 
        public List<ProductModel> GetAllProductModels()
        {
            List<ProductModel> _allProducts = new();

            foreach (ProductModel Product in Products)
            {
                _allProducts.Add(Product);
            }

            return _allProducts;
        }

        //AddProduct essentially takes User Input and uses that to add it to the product list.
        //It uses the Parameters given of ID, ProductName, etc
        public void AddProduct(ProductModel product)
        {
            Products.Add(product);

        }
        public void AddProduct(int id, string productName, string description, int salePrice, int buyPrice,
            string location, float storageAmount, Measure measure)
        {
            Products.Add(new ProductModel(id, productName, description, salePrice, buyPrice, location, storageAmount,
                Measure.Meter));
        }

        //UpdateProduct uses foreach and If to Identity the product, then updates it, 
        //Void is used to avoid method wanting a return
        public void UpdateProduct(int ID, string productName, string description, int salePrice, int buyPrice,
            string location, float storageAmount, Measure measure)
        {
            foreach (ProductModel product in Products)
            {
                if (product.ID == ID)
                {
                    product.ProductName = productName;
                    product.Description = description;
                    product.SellPrice = salePrice;
                    product.BuyPrice = buyPrice;
                    product.Location = location;
                    product.StorageAmount = storageAmount;
                    product.Measure = measure;
                }
            }
        }

        //RemoveProduct uses the if and foreach to identify the right product, then uses remove product.
        //Break is used due to the product going back to product afterwards and
        //crashes due to ID not existing anymore.
        public void RemoveProduct(int ID)
        {
            foreach (ProductModel product in Products)
            {
                if (product.ID == ID)
                {
                    Products.Remove(product);
                    break;
                }
            }
        }
    }
}