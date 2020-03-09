using System;
using System.Collections.Generic;

namespace SDC.Models
{
    public partial class CodeCategory
    {
        public CodeCategory()
        {
            CodeList = new HashSet<CodeList>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public ICollection<CodeList> CodeList { get; set; }
    }
}
