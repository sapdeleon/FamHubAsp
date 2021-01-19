using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FamHubAsp.Models
{
    public class Product
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string ProductCode { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Brand { get; set; }
        public string Supplier { get; set; }

        public Product()
        {

        }

        public Product(Product product)
        {
            ProductCode = product.ProductCode;
            Description = product.Description;
            Type = product.Type;
            Color = product.Color;
            Size = product.Size;
            Brand = product.Brand;
            Supplier = product.Supplier;
        }
    }
}
