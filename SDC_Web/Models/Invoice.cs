using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SDC_Web.Models
{
    public partial class Invoice
    {
        [Required]
        public int ProjectId { get; set; }
        [Required]
        public DateTime InvoiceDate { get; set; }
        public int? Terms { get; set; }
        [Required]
        public string BillPlace { get; set; }
        [Required]
        public string BillAddress { get; set; }
        public string BillPhone { get; set; }
        public string BillEmail { get; set; }
        [Required]
        public string ShipPlace { get; set; }
        [Required]
        public string ShipAddress { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? Shipping { get; set; }
        public decimal? Hst { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? InvoiceBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedTime { get; set; }

        public Employee InvoiceByNavigation { get; set; }
        public Project Project { get; set; }
        public Employee UpdatedByNavigation { get; set; }
    }
}
