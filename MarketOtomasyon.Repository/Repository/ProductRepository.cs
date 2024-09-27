using MarketOtomasyon.Entities;
using MarketOtomasyon.Repository.Context;

namespace MarketOtomasyon.Repository.Repository
{
    public class ProductRepository
    {
        AppDbContext db;
        public ProductRepository()
        {
            db = new AppDbContext();
        }
        public Product GetProductById(int id)
        {
            var product = db.Products.Find(id);
            return product;
        }
        public List<Product> GetAllProducts()
        {
            var productList = db.Products.ToList();
            return productList;
        }
        public void AddProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }
        public void UpdateProduct(Product product)
        {
            db.Products.Update(product);
            db.SaveChanges();
        }
        public void DeleteProduct(int id)
        {
            var product = GetProductById(id);
            db.Products.Remove(product);
            db.SaveChanges();
        }
    }
}
