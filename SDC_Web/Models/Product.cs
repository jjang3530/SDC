using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SDC_Web.Models
{
    public partial class Product
    {
        [Required]
        public int SupplierId { get; set; }
        [Required]
        public string ProductId { get; set; }
        public string Dimension { get; set; }
        public string Description { get; set; }
        public string Finishes { get; set; }
        public string Uom { get; set; }
        public decimal? Price { get; set; }
        public string BookNumber { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public Employee CreatedByNavigation { get; set; }
    }
}
