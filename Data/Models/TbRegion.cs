using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class TbRegion
    {
        public int RegionPkid { get; set; }
        public string TownshipId { get; set; }
        public string RegionCode { get; set; }
        public string Region { get; set; }
    }
}
