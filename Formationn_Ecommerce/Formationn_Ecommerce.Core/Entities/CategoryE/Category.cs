﻿using Formationn_Ecommerce.Core.Common;
using Formationn_Ecommerce.Core.Entities.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formationn_Ecommerce.Core.Entities.CategoryE
{
    public class Category : BaseEntity
    {
        [Required(ErrorMessage = "The Category name is required.")]
        [MaxLength(100, ErrorMessage = " The Category name cannot exceed 100 Characters .")]
        public string Name { get; set; }




        [MaxLength(500, ErrorMessage = "The description cannot exceed 500 characters.")]
        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
