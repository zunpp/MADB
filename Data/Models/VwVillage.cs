using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class VwVillage
    {
        public int VillagePkid { get; set; }
        public string TownshipId { get; set; }
        public string Township { get; set; }
        public string VillageCode { get; set; }
        public string VillageName { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
