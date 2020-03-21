using System;
using System.Collections.Generic;

namespace SDC_API.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            PurchaseOrder = new HashSet<PurchaseOrder>();
        }

        public int SupplierId { get; set; }
        public string Company { get; set; }
        public string Category { get; set; }
        public string Account { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Postalcode { get; set; }
        public string Phone { get; set; }
        public string RepName { get; set; }
        public string RepEmail { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }

        public Employee CreatedByNavigation { get; set; }
        public SupplierLogin SupplierLogin { get; set; }
        public SupplierOrder SupplierOrder { get; set; }
        public ICollection<PurchaseOrder> PurchaseOrder { get; set; }
    }
}
