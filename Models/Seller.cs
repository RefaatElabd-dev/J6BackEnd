using System;
using System.Collections.Generic;

#nullable disable

namespace J6BackEnd.Models
{
    public partial class Seller
    {
        public Seller()
        {
            Promotions = new HashSet<Promotion>();
            Stores = new HashSet<Store>();
        }

        public int Id { get; set; }

        public virtual User IdNavigation { get; set; }
        public virtual ICollection<Promotion> Promotions { get; set; }
        public virtual ICollection<Store> Stores { get; set; }
    }
}
