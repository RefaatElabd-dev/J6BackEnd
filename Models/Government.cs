using System;
using System.Collections.Generic;

#nullable disable

namespace J6BackEnd.Models
{
    public partial class Government
    {
        public Government()
        {
            Cities = new HashSet<City>();
        }

        public int GovernmentId { get; set; }
        public string GovernmentName { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}
