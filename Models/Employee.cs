using System;
using System.Collections.Generic;

#nullable disable

namespace J6BackEnd.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Carts = new HashSet<Cart>();
        }

        public int Id { get; set; }
        public DateTime? HireDate { get; set; }
        public string Salary { get; set; }

        public virtual User IdNavigation { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
    }
}
