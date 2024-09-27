using MarketOtomasyon.Entities;
using MarketOtomasyon.FormUI.ViewModels;
using MarketOtomasyon.Repository.Repository;

namespace MarketOtomasyon.Services
{
    public class ProductService
    {
        ProductRepository _productRepository;

        public ProductService(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public ProductViewModel GetProductById(int id)
        {
            if (id > 0)
            {

                var product = _productRepository.GetProductById(id);
                if (product != null)
                {
                   var model =  new ProductViewModel
                    {
                        CategoryId = product.CategoryId,
                        ProductName = product.ProductName

                    };
                    return model;
                }
            }
            return null;
        }
        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }
    }
}
