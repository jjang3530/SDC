﻿using System;
using System.Collections.Generic;

namespace SDC_API.Models
{
    public partial class PurchaseOrderdetail
    {
        public int ProjectId { get; set; }
        public int OrderId { get; set; }
        public string ProductId { get; set; }
        public string Dimension { get; set; }
        public string Description { get; set; }
        public int? Pattern { get; set; }
        public int? Colour { get; set; }
        public decimal? Quantity { get; set; }
        public string Uom { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Amount { get; set; }
        public string DeliveryStatus { get; set; }
        public int? OrderedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedTime { get; set; }

        public Employee OrderedByNavigation { get; set; }
        public PurchaseOrder PurchaseOrder { get; set; }
        public Employee UpdatedByNavigation { get; set; }
        public PurchaseStock PurchaseStock { get; set; }
    }
}
