using System;
using System.Collections.Generic;

#nullable disable

namespace J6BackEnd.Models
{
    public partial class Cart
    {
        public Cart()
        {
            ProdCarts = new HashSet<ProdCart>();
        }

        public int Cartid { get; set; }
        public string Paymentid { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ShippingDate { get; set; }
        public int? Cost { get; set; }
        public int? EmployeeId { get; set; }
        public int? CustId { get; set; }
        public int? ShippingDetailsId { get; set; }

        public virtual Customer Cust { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ShippingDetail ShippingDetails { get; set; }
        public virtual ICollection<ProdCart> ProdCarts { get; set; }
    }
}
