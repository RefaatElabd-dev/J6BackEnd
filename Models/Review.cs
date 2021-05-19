using System;
using System.Collections.Generic;

#nullable disable

namespace J6BackEnd.Models
{
    public partial class Review
    {
        public int CustimerId { get; set; }
        public int ProductId { get; set; }
        public string Comment { get; set; }
        public string Rating { get; set; }

        public virtual Customer Custimer { get; set; }
        public virtual Product Product { get; set; }
    }
}
