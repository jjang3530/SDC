using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SDC_Web.Models
{
    public partial class PurchaseOrder
    {
        public PurchaseOrder()
        {
            PurchaseOrderdetail = new HashSet<PurchaseOrderdetail>();
        }
        [Required]
        public int ProjectId { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int SupplierId { get; set; }
        [Required]
        public string ShippingPlace { get; set; }
        [Required]
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
