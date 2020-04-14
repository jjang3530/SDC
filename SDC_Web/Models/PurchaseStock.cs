using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SDC_Web.Models
{
    public partial class PurchaseStock
    {
        [Required]
        public int ProjectId { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public string ProductId { get; set; }
        public string Dimension { get; set; }
        public string Description { get; set; }
        public int? Pattern { get; set; }
        public int? Colour { get; set; }
        public decimal? Quantity { get; set; }
        public string Uom { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Amount { get; set; }
        public int? ReceivedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedTime { get; set; }

        public PurchaseOrderdetail PurchaseOrderdetail { get; set; }
        public Employee ReceivedByNavigation { get; set; }
        public Employee UpdatedByNavigation { get; set; }
    }
}
