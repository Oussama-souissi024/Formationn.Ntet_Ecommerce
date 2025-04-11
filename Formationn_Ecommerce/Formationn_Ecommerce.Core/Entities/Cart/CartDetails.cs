using Formationn_Ecommerce.Core.Common;
using Formationn_Ecommerce.Core.Entities.Products;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Formationn_Ecommerce.Core.Entities.Cart
{
    public class CartDetails : BaseEntity
    {
        [Required]
        [ForeignKey("CartHeader")]
        public Guid CartHeaderId { get; set; }

        public Guid ProductId { get; set; }

        [Required]
        [Range(1, 100, ErrorMessage = "The value must be between 1 and 100.")]
        public int Count { get; set; }


        public CartHeader CartHeader { get; set; }
        public Product Product { get; set; }

    }
}
