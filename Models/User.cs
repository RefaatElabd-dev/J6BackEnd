﻿using System;
using System.Collections.Generic;

#nullable disable

namespace J6BackEnd.Models
{
    public partial class User
    {
        public User()
        {
            CustomerAddresses = new HashSet<CustomerAddress>();
            CustomerPhones = new HashSet<CustomerPhone>();
            UserAddresses = new HashSet<UserAddress>();
            UserPhones = new HashSet<UserPhone>();
        }

        public int Userid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? RoleId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Seller Seller { get; set; }
        public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }
        public virtual ICollection<CustomerPhone> CustomerPhones { get; set; }
        public virtual ICollection<UserAddress> UserAddresses { get; set; }
        public virtual ICollection<UserPhone> UserPhones { get; set; }
    }
}
