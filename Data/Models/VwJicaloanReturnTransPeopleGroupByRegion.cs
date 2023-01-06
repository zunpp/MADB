using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class VwJicaloanReturnTransPeopleGroupByRegion
    {
        public string TownshipId { get; set; }
        public string RegionId { get; set; }
        public string Manufacturer { get; set; }
        public string MachineType { get; set; }
        public string TotalPeople { get; set; }
        public string PaidPeople { get; set; }
        public string DebtPeople { get; set; }
        public string PeoplePercentage { get; set; }
        public string DebtPeoplePercentage { get; set; }
    }
}
