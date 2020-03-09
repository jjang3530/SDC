using System;
using System.Collections.Generic;

namespace SDC.Models
{
    public partial class JobType
    {
        public JobType()
        {
            Employee = new HashSet<Employee>();
        }

        public int JobId { get; set; }
        public string JobTitle { get; set; }

        public ICollection<Employee> Employee { get; set; }
    }
}
