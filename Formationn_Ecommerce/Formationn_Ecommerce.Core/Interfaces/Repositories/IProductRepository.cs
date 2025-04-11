

using Formationn_Ecommerce.Core.Entities.Products;
using Formationn_Ecommerce.Core.Interfaces.Repositories.Base;

namespace Formationn_Ecommerce.Core.Interfaces.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<Product> AddAsync(Product product);
        Task<Product> ReadByIdAsync(Guid productId);
        Task<IEnumerable<Product>> ReadAllAsync();
        Task UpdateAsync(Product product);
        Task<bool> DeleteAsync(Guid productId);
    }
}
