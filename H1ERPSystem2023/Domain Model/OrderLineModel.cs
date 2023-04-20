#pragma warning disable
namespace H1ERPSystem2023.DomainModel
{
    public class OrderLineModel
    {
        // Gets all the proberties from the ProductModel
        public ProductModel Product { get; set; }

        public OrderLineModel(ProductModel product)
        {
            this.Product = new(product.ID, product.ProductName, product.Description, product.SalePrice,
                product.BuyPrice, product.Location, product.Quantity, product.Measure);
        }
    }
}