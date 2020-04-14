using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SDC_Web.Models
{
    public partial class CodeCategory
    {
        public CodeCategory()
        {
            CodeList = new HashSet<CodeList>();
        }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; }

        public ICollection<CodeList> CodeList { get; set; }
    }
}
