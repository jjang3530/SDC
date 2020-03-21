using System;
using System.Collections.Generic;

namespace SDC_API.Models
{
    public partial class Items
    {
        public int ProjectId { get; set; }
        public string RoomId { get; set; }
        public string ProductId { get; set; }
        public string Dimension { get; set; }
        public string Description { get; set; }
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
