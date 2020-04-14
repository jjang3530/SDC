using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SDC_Web.Models
{
    public partial class CodeList
    {
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public int CodeId { get; set; }
        [Required]
        public string CodeName { get; set; }

        public CodeCategory Category { get; set; }
    }
}
