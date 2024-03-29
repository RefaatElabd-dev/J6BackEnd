﻿using System;
using System.Collections.Generic;

#nullable disable

namespace J6BackEnd.Models
{
    public partial class StoreProduct
    {
        public int ProductId { get; set; }
        public int StoreId { get; set; }
        public int? Quantities { get; set; }

        public virtual Product Product { get; set; }
        public virtual Store Store { get; set; }
    }
}
