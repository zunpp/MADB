using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class TbVillage
    {
        public int VillagePkid { get; set; }
        public string TownshipId { get; set; }
        public string VillageCode { get; set; }
        public string VillageName { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
