﻿using System;
using System.Collections.Generic;

#nullable disable

namespace J6BackEnd.Models
{
    public partial class ProdOrder
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product OrderNavigation { get; set; }
    }
}
