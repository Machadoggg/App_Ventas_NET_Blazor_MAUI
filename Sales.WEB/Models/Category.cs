namespace Sales.WEB.Models
{
    public class Category
    {
        public string Name { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
    }

    public class ProductCategory
    { 
        public string Name { get; set; } 
        public List<Product> Products { get; set; } 
    }

    public class Product
    {
        public string Name { get; set; }
    }
}
