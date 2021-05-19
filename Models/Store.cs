using System;
using System.Collections.Generic;

#nullable disable

namespace J6BackEnd.Models
{
    public partial class Store
    {
        public Store()
        {
            StoreProducts = new HashSet<StoreProduct>();
        }

        public int StoreId { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string BuildingNumber { get; set; }
        public int? SellerId { get; set; }

        public virtual Seller Seller { get; set; }
        public virtual ICollection<StoreProduct> StoreProducts { get; set; }
    }
}
