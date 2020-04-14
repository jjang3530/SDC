using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SDC_Web.Models
{
    public partial class Project
    {
        public Project()
        {
            PurchaseOrder = new HashSet<PurchaseOrder>();
            Room = new HashSet<Room>();
        }

        [Required]
        public int ProjectId { get; set; }
        [Required]
        public string ProjectTag { get; set; }
        [Required]
        public int ClientId { get; set; }
        [Required]
        public string Status { get; set; }
        public int? DesignedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedTime { get; set; }

        public Client Client { get; set; }
        public Employee DesignedByNavigation { get; set; }
        public Employee UpdatedByNavigation { get; set; }
        public Invoice Invoice { get; set; }
        public ICollection<PurchaseOrder> PurchaseOrder { get; set; }
        public ICollection<Room> Room { get; set; }
    }
}
