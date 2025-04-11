
using Formationn_Ecommerce.Core.Entities.Coupon;
using Formationn_Ecommerce.Core.Interfaces.Repositories.Base;

namespace Formationn_Ecommerce.Core.Interfaces.Repositories
{
    public interface ICouponRepository : IRepository<Coupon>
    {
        Task<Coupon> AddAsync(Coupon coupon);
        Task<Coupon> ReadByIdAsync(Guid couponId);
        Task<Coupon> ReadByCouponCodeAsync(string couponCode);
        Task<IEnumerable<Coupon>> ReadAllAsync();
        Task UpdateAsync(Coupon coupon);
        Task DeleteAsync(Guid id);
    }
}
