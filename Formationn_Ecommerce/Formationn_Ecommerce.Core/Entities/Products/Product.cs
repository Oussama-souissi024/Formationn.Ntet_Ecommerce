using Formationn_Ecommerce.Core.Common;
using Formationn_Ecommerce.Core.Entities.Cart;
using Formationn_Ecommerce.Core.Entities.CategoryE;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Formationn_Ecommerce.Core.Entities.Products
{
    public class Product : BaseEntity
    {
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        public string Description { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }

        public Category Category { get; set; }

        public ICollection<CartDetails> CartDetails { get; set; }

    }
}
