using System;
using System.Collections.Generic;

namespace SDC.Models
{
    public partial class Invoice
    {
        public int ProjectId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int? Terms { get; set; }
        public string BillPlace { get; set; }
        public string BillAddress { get; set; }
        public string BillPhone { get; set; }
        public string BillEmail { get; set; }
        public string ShipPlace { get; set; }
        public string ShipAddress { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? Shipping { get; set; }
        public decimal? Hst { get; set; }
        public decimal? TotalAmount { get; set; }
        public string InvoiceBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedTime { get; set; }

        public Employee InvoiceByNavigation { get; set; }
        public Project Project { get; set; }
        public Employee UpdatedByNavigation { get; set; }
    }
}
