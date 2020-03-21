using System;
using System.Collections.Generic;

namespace SDC_API.Models
{
    public partial class PurchaseOrder
    {
        public PurchaseOrder()
        {
            PurchaseOrderdetail = new HashSet<PurchaseOrderdetail>();
        }

        public int ProjectId { get; set; }
        public int OrderId { get; set; }
        public int SupplierId { get; set; }
        public string ShippingPlace { get; set; }
        public string ShippingAddress { get; set; }
        public string ShippingPhone { get; set; }
        public DateTime? EstimatedShipdate { get; set; }
        public int? OrderedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedTime { get; set; }

        public Employee OrderedByNavigation { get; set; }
        public Project Project { get; set; }
        public Supplier Supplier { get; set; }
        public Employee UpdatedByNavigation { get; set; }
        public ICollection<PurchaseOrderdetail> PurchaseOrderdetail { get; set; }
    }
}
