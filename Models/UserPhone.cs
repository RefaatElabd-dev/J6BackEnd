using System;
using System.Collections.Generic;

#nullable disable

namespace J6BackEnd.Models
{
    public partial class UserPhone
    {
        public int UserId { get; set; }
        public string PhoneNumber { get; set; }

        public virtual User User { get; set; }
    }
}
