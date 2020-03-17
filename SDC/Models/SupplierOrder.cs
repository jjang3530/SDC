using System;
using System.Collections.Generic;

namespace SDC_API.Models
{
    public partial class SupplierOrder
    {
        public int SupplierId { get; set; }
        public string OrderingMethod { get; set; }
        public string OrderingEmail { get; set; }
        public string PriceFound { get; set; }
        public string DiscountOw { get; set; }
        public string DiscountOr { get; set; }
        public string DiscountNotes { get; set; }
        public string Terms { get; set; }
        public string LeadTime { get; set; }
        public decimal? SalesReq { get; set; }
        public int? Books { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentNotes { get; set; }

        public Supplier Supplier { get; set; }
    }
}
