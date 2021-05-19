using System;
using System.Collections.Generic;

#nullable disable

namespace J6BackEnd.Models
{
    public partial class ProductBrand
    {
        public int ProductId { get; set; }
        public int BrandId { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Product Product { get; set; }
    }
}
