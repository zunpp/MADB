using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class VwTownship
    {
        public int TownshipPkid { get; set; }
        public string StateDivisionId { get; set; }
        public string StateDivision { get; set; }
        public string TownshipCode { get; set; }
        public string Township { get; set; }
    }
}
