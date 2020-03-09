using System;
using System.Collections.Generic;

namespace SDC.Models
{
    public partial class Employee
    {
        public Employee()
        {
            DraperyDesignedByNavigation = new HashSet<Drapery>();
            DraperyUpdatedByNavigation = new HashSet<Drapery>();
            InvoiceInvoiceByNavigation = new HashSet<Invoice>();
            InvoiceUpdatedByNavigation = new HashSet<Invoice>();
            ItemsDesignedByNavigation = new HashSet<Items>();
            ItemsUpdatedByNavigation = new HashSet<Items>();
            ProjectDesignedByNavigation = new HashSet<Project>();
            ProjectUpdatedByNavigation = new HashSet<Project>();
            PurchaseOrderOrderedByNavigation = new HashSet<PurchaseOrder>();
            PurchaseOrderUpdatedByNavigation = new HashSet<PurchaseOrder>();
            PurchaseOrderdetailOrderedByNavigation = new HashSet<PurchaseOrderdetail>();
            PurchaseOrderdetailUpdatedByNavigation = new HashSet<PurchaseOrderdetail>();
            PurchaseStockReceivedByNavigation = new HashSet<PurchaseStock>();
            PurchaseStockUpdatedByNavigation = new HashSet<PurchaseStock>();
            RoomDesignedByNavigation = new HashSet<Room>();
            RoomUpdatedByNavigation = new HashSet<Room>();
            Supplier = new HashSet<Supplier>();
        }

        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public int JobId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Postalcode { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public JobType Job { get; set; }
        public ICollection<Drapery> DraperyDesignedByNavigation { get; set; }
        public ICollection<Drapery> DraperyUpdatedByNavigation { get; set; }
        public ICollection<Invoice> InvoiceInvoiceByNavigation { get; set; }
        public ICollection<Invoice> InvoiceUpdatedByNavigation { get; set; }
        public ICollection<Items> ItemsDesignedByNavigation { get; set; }
        public ICollection<Items> ItemsUpdatedByNavigation { get; set; }
        public ICollection<Project> ProjectDesignedByNavigation { get; set; }
        public ICollection<Project> ProjectUpdatedByNavigation { get; set; }
        public ICollection<PurchaseOrder> PurchaseOrderOrderedByNavigation { get; set; }
        public ICollection<PurchaseOrder> PurchaseOrderUpdatedByNavigation { get; set; }
        public ICollection<PurchaseOrderdetail> PurchaseOrderdetailOrderedByNavigation { get; set; }
        public ICollection<PurchaseOrderdetail> PurchaseOrderdetailUpdatedByNavigation { get; set; }
        public ICollection<PurchaseStock> PurchaseStockReceivedByNavigation { get; set; }
        public ICollection<PurchaseStock> PurchaseStockUpdatedByNavigation { get; set; }
        public ICollection<Room> RoomDesignedByNavigation { get; set; }
        public ICollection<Room> RoomUpdatedByNavigation { get; set; }
        public ICollection<Supplier> Supplier { get; set; }
    }
}
