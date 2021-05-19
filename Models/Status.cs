using System;
using System.Collections.Generic;

#nullable disable

namespace J6BackEnd.Models
{
    public partial class Status
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public int? OrderId { get; set; }
    }
}
