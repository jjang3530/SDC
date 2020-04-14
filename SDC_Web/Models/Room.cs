using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SDC_Web.Models
{
    public partial class Room
    {
        public Room()
        {
            Drapery = new HashSet<Drapery>();
            Items = new HashSet<Items>();
        }

        [Required]
        public int ProjectId { get; set; }
        [Required]
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
        public decimal? TrimDepth { get; set; }
        public decimal? InsideDepth { get; set; }
        public string Sill { get; set; }
        public string Control { get; set; }
        public string Notes { get; set; }
        public int? DesignedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedTime { get; set; }

        public Employee DesignedByNavigation { get; set; }
        public Project Project { get; set; }
        public Employee UpdatedByNavigation { get; set; }
        public ICollection<Drapery> Drapery { get; set; }
        public ICollection<Items> Items { get; set; }
    }
}
