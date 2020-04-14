using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SDC_Web.Models
{
    public partial class Drapery
    {
        [Required]
        public int ProjectId { get; set; }
        [Required]
        public string RoomId { get; set; }
        [Required]
        public int DraperyId { get; set; }
        [Required]
        public string TypeName { get; set; }
        [Required]
        public string TypeValue { get; set; }
        public int? DesignedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedTime { get; set; }

        public Employee DesignedByNavigation { get; set; }
        public Room Room { get; set; }
        public Employee UpdatedByNavigation { get; set; }
    }
}
