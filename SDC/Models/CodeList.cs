using System;
using System.Collections.Generic;

namespace SDC_API.Models
{
    public partial class CodeList
    {
        public int CategoryId { get; set; }
        public int CodeId { get; set; }
        public string CodeName { get; set; }

        public CodeCategory Category { get; set; }
    }
}
