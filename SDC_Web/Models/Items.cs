using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SDC_Web.Models
{
    public partial class Items
    {
        [Required]
        public int ProjectId { get; set; }
        [Required]
        public string RoomId { get; set; }
        [Required]
        public string ProductId { get; set; }
        public string Dimension { get; set; }
        public string Description { get; set; }
        [Required]
        public int SupplierId { get; set; }
        public int? Pattern { get; set; }
        public int? Colour { get; set; }
        public decimal? Quantity { get; set; }
        public string Uom { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? RetailPrice { get; set; }
        public decimal? Amount { get; set; }
        public decimal? RetailAmount { get; set; }
        public int? DesignedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedTime { get; set; }

        public Employee DesignedByNavigation { get; set; }
        public Room Room { get; set; }
        public Employee UpdatedByNavigation { get; set; }
    }
}
