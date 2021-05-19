using System;
using System.Collections.Generic;

#nullable disable

namespace J6BackEnd.Models
{
    public partial class View
    {
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public string IsFar { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}
