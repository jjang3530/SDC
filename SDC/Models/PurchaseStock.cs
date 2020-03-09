using System;
using System.Collections.Generic;

namespace SDC.Models
{
    public partial class PurchaseStock
    {
        public int ProjectId { get; set; }
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int? Pattern { get; set; }
        public int? Colour { get; set; }
        public decimal? Quantity { get; set; }
        public int Uom { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Amount { get; set; }
        public string ReceivedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedTime { get; set; }

        public PurchaseOrderdetail PurchaseOrderdetail { get; set; }
        public Employee ReceivedByNavigation { get; set; }
        public Employee UpdatedByNavigation { get; set; }
    }
}
