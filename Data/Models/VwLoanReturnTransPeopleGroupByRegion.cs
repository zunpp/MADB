using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class VwLoanReturnTransPeopleGroupByRegion
    {
        public string TownshipId { get; set; }
        public string RegionId { get; set; }
        public string LoanYear { get; set; }
        public string LoanSeason { get; set; }
        public string TotalPeople { get; set; }
        public string PaidPeople { get; set; }
        public string DebtPeople { get; set; }
        public string PeoplePercentage { get; set; }
        public string DebtPeoplePercentage { get; set; }
    }
}
