using System;
using System.Collections.Generic;

#nullable disable

namespace J6BackEnd.Models
{
    public partial class Promotion
    {
        public Promotion()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public int? Discount { get; set; }
        public string Description { get; set; }
        public int? SellerId { get; set; }

        public virtual Seller Seller { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
