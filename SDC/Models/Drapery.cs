using System;
using System.Collections.Generic;

namespace SDC_API.Models
{
    public partial class Drapery
    {
        public int ProjectId { get; set; }
        public string RoomId { get; set; }
        public int DraperyId { get; set; }
        public string TypeName { get; set; }
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
