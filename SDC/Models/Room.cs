using System;
using System.Collections.Generic;

namespace SDC.Models
{
    public partial class Room
    {
        public Room()
        {
            Drapery = new HashSet<Drapery>();
            Items = new HashSet<Items>();
        }

        public int ProjectId { get; set; }
        public string RoomId { get; set; }
        public decimal? FloorCeiling { get; set; }
        public decimal? TotCeiling { get; set; }
        public decimal? BotFloor { get; set; }
        public decimal? LootObject { get; set; }
        public decimal? RootObject { get; set; }
        public decimal? InsideHorizontal { get; set; }
        public decimal? InsideVertical { get; set; }
        public decimal? OutsideHorizontal { get; set; }
        public decimal? OutsideVertical { get; set; }
        public string DesignedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedTime { get; set; }

        public Employee DesignedByNavigation { get; set; }
        public Project Project { get; set; }
        public Employee UpdatedByNavigation { get; set; }
        public ICollection<Drapery> Drapery { get; set; }
        public ICollection<Items> Items { get; set; }
    }
}
