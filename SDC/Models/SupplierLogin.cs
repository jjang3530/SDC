using System;
using System.Collections.Generic;

namespace SDC.Models
{
    public partial class SupplierLogin
    {
        public int SupplierId { get; set; }
        public string Website { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Notes { get; set; }

        public Supplier Supplier { get; set; }
    }
}
