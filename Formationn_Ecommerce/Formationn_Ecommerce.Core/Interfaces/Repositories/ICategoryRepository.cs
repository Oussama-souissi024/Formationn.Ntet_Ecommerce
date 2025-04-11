

using Formationn_Ecommerce.Core.Entities.CategoryE;
using Formationn_Ecommerce.Core.Interfaces.Repositories.Base;

namespace Formationn_Ecommerce.Core.Interfaces.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<Category> AddAsync(Category category);
        Task<Category> ReadByIdAsync(Guid categoryId);
        Task<IEnumerable<Category>> ReadAllAsync();
        Task<Guid?> GetCategoryIdByCategoryNameAsync(string categoryName);
        Task Update(Category category);
        Task DeleteAsync(Guid categoryId);
    }
}
