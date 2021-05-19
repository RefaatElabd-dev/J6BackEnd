using System;
using System.Collections.Generic;

#nullable disable

namespace J6BackEnd.Models
{
    public partial class Order
    {
        public Order()
        {
            ProdOrders = new HashSet<ProdOrder>();
        }

        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int? Rating { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<ProdOrder> ProdOrders { get; set; }
    }
}
