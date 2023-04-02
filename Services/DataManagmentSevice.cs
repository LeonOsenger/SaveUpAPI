using SaveUpAPI.DTO;
using SaveUpAPI.Models;

namespace SaveUpAPI.Services
{
    public class DataManagmentSevice : IDataManagmentService
    {
        private readonly SaveUpContext _dbContext;

        public DataManagmentSevice(SaveUpContext dbContext) 
        {
            _dbContext = dbContext; 
        }

        public List<SaveUpDTO> GetAllProducts()
        {
            List<Product> products = _dbContext.Products.ToList();
            List<SaveUpDTO> result = new List<SaveUpDTO>();

            products.ForEach(p => result.Add(new SaveUpDTO()
            {
                Id = p.Id,
                price = p.Price,
                description = p.Description

            }));

            return result;
        }

        public Product? GetProductById(Guid id)
        {
            return _dbContext.Products
                .FirstOrDefault(x => x.Id == id);
        }

        public void PostNewProduct(SaveUpPostDTO product)
        {
            var addProduct = new Product()
            {
                Price = product.price,
                Description = product.description
            };

            _dbContext.Products.Add(addProduct);
            _dbContext.SaveChanges();
        }

        public void DeleteSelectedProduct(Guid productId)
        {
            var product = _dbContext.Products.Find(productId);
            if (product != null)
            {
                _dbContext.Products.Remove(product);
                _dbContext.SaveChanges();
            }
        }

        public void DeleteAllProducts()
        {
            List<Product> products = _dbContext.Products.ToList();
            foreach (var p in products)
            {
                if (p != null)
                {
                    _dbContext.Products.Remove(p);
                    _dbContext.SaveChanges();
                }
            }
            
        }
    }
}
