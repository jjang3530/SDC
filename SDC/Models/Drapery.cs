using System;
using System.Collections.Generic;

namespace SDC.Models
{
    public partial class Drapery
    {
        public int ProjectId { get; set; }
        public string RoomId { get; set; }
        public int DraperyId { get; set; }
        public string TypeName { get; set; }
        public string TypeValue { get; set; }
        public string DesignedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedTime { get; set; }

        public Employee DesignedByNavigation { get; set; }
        public Room Room { get; set; }
        public Employee UpdatedByNavigation { get; set; }
    }
}
