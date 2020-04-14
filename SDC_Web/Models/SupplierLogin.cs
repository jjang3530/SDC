using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SDC_Web.Models
{
    public partial class SupplierLogin
    {
        [Required]
        public int SupplierId { get; set; }
        public string Website { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Notes { get; set; }

        public Supplier Supplier { get; set; }
    }
}
