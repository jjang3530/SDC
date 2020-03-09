using System;
using System.Collections.Generic;

namespace SDC.Models
{
    public partial class Project
    {
        public Project()
        {
            PurchaseOrder = new HashSet<PurchaseOrder>();
            Room = new HashSet<Room>();
        }

        public int ProjectId { get; set; }
        public string ProjectTag { get; set; }
        public int ClientId { get; set; }
        public string Status { get; set; }
        public string DesignedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedTime { get; set; }

        public Client Client { get; set; }
        public Employee DesignedByNavigation { get; set; }
        public Employee UpdatedByNavigation { get; set; }
        public Invoice Invoice { get; set; }
        public ICollection<PurchaseOrder> PurchaseOrder { get; set; }
        public ICollection<Room> Room { get; set; }
    }
}
