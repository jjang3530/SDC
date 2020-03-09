using System;
using System.Collections.Generic;

namespace SDC.Models
{
    public partial class PurchaseOrderdetail
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
        public string DeliveryStatus { get; set; }
        public string OrderedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedTime { get; set; }

        public Employee OrderedByNavigation { get; set; }
        public PurchaseOrder PurchaseOrder { get; set; }
        public Employee UpdatedByNavigation { get; set; }
        public PurchaseStock PurchaseStock { get; set; }
    }
}
