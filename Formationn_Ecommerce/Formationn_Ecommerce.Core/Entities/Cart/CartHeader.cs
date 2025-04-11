using Formationn_Ecommerce.Core.Common;
using Formationn_Ecommerce.Core.Entities.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formationn_Ecommerce.Core.Entities.Cart
{
    public class CartHeader : BaseEntity
    {
        [Required]
        [ForeignKey("User")]
        public string UserID { get; set; }

        public string CouponCode { get; set; }


        public ApplicationUser User { get; set; }


        public ICollection<CartDetails> CartDetails { get; set; }


    }
}
