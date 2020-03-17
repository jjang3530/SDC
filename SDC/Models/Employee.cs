using System;
using System.Collections.Generic;

namespace SDC_API.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Product = new HashSet<Product>();
            Supplier = new HashSet<Supplier>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public int JobId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Postalcode { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public JobType Job { get; set; }
        public ICollection<Product> Product { get; set; }
        public ICollection<Supplier> Supplier { get; set; }
    }
}
