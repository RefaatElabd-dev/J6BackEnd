﻿using System;
using System.Collections.Generic;

#nullable disable

namespace J6BackEnd.Models
{
    public partial class ProductImage
    {
        public int ProductId { get; set; }
        public int ImageId { get; set; }
        public string Image { get; set; }

        public virtual Product Product { get; set; }
    }
}
