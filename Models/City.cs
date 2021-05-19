using System;
using System.Collections.Generic;

#nullable disable

namespace J6BackEnd.Models
{
    public partial class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int GovernmentId { get; set; }

        public virtual Government Government { get; set; }
    }
}
