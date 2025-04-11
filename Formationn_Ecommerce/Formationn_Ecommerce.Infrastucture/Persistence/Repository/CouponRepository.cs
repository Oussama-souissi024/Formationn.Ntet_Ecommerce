using Formationn_Ecommerce.Core.Entities.Coupon;
using Formationn_Ecommerce.Core.Interfaces.Repositories;
using Formationn_Ecommerce.Core.Interfaces.Repositories.Base;
using Formationn_Ecommerce.Infrastucture.Persistence.Repository.Base;
using Microsoft.EntityFrameworkCore;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formationn_Ecommerce.Infrastucture.Persistence.Repository
{
    public class CouponRepository : Repository<Core.Entities.Coupon.Coupon>, ICouponRepository
    {
        private readonly ApplicationDbContext _Context;
        public CouponRepository(ApplicationDbContext context) : base(context)
        {
            _Context = context;
        }

        public async Task<Core.Entities.Coupon.Coupon> AddAsync(Core.Entities.Coupon.Coupon coupon)
        {
            await _context.Coupons.AddAsync(coupon);
            await _context.SaveChangesAsync();
            return coupon;
        }

        public async Task<Core.Entities.Coupon.Coupon> ReadByIdAsync(Guid couponId)
        {
            return await _context.Coupons.FirstOrDefaultAsync(c => c.Id == couponId);
        }

        public async Task<Core.Entities.Coupon.Coupon> ReadByCouponCodeAsync(string couponCode)
        {
            return await _context.Coupons.FirstOrDefaultAsync(c => c.CouponCode.ToLower() == couponCode.ToLower());
        }


        public async Task<IEnumerable<Core.Entities.Coupon.Coupon>> ReadAllAsync()
        {
            return await _context.Coupons.ToListAsync();
        }

        public async Task UpdateAsync(Core.Entities.Coupon.Coupon coupon)
        {
            _context.Coupons.Update(coupon);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var coupon = await _context.Coupons.FindAsync(id);
            if( coupon != null)
            {
                _context.Coupons.Remove(coupon);
                await _context.SaveChangesAsync();
            }

        }



      
        public Task Remove(Core.Entities.Coupon.Coupon entity)
        {
            throw new NotImplementedException();
        }

        public async Task Update(Core.Entities.Coupon.Coupon entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Core.Entities.Coupon.Coupon>> IRepository<Core.Entities.Coupon.Coupon>.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<Core.Entities.Coupon.Coupon> IRepository<Core.Entities.Coupon.Coupon>.GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
