using SaveUpAPI.DTO;
using SaveUpAPI.Models;

namespace SaveUpAPI.Services
{
    public interface IDataManagmentService
    {
        List<SaveUpDTO> GetAllProducts();

        public Product? GetProductById(Guid id);

        void PostNewProduct(SaveUpPostDTO product);

        void DeleteSelectedProduct(Guid productId);

        void DeleteAllProducts();
    }
}
