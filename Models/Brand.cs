using System;
using System.Collections.Generic;

#nullable disable

namespace J6BackEnd.Models
{
    public partial class Brand
    {
        public Brand()
        {
            ProductBrands = new HashSet<ProductBrand>();
        }

        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<ProductBrand> ProductBrands { get; set; }
    }
}
