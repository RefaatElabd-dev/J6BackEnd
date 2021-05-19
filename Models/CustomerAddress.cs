using System;
using System.Collections.Generic;

#nullable disable

namespace J6BackEnd.Models
{
    public partial class CustomerAddress
    {
        public int UserId { get; set; }
        public int AddressId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int? PostalCode { get; set; }

        public virtual User User { get; set; }
    }
}
