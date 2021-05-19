using System;
using System.Collections.Generic;

#nullable disable

namespace J6BackEnd.Models
{
    public partial class ProdCart
    {
        public int CartId { get; set; }
        public int ProductId { get; set; }

        public virtual Cart Cart { get; set; }
        public virtual Product CartNavigation { get; set; }
    }
}
