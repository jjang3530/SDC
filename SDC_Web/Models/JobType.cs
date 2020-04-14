using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SDC_Web.Models
{
    public partial class JobType
    {
        public JobType()
        {
            Employee = new HashSet<Employee>();
        }

        [Required]
        public int JobId { get; set; }
        [Required]
        public string JobTitle { get; set; }

        public ICollection<Employee> Employee { get; set; }
    }
}
