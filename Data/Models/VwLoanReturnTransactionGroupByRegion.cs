using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class VwLoanReturnTransactionGroupByRegion
    {
        public string RegionId { get; set; }
        public string TownshipId { get; set; }
        public string StateDivisionId { get; set; }
        public string LoanYear { get; set; }
        public string LoanSeason { get; set; }
        public string TotalLoan { get; set; }
        public string TotalReturn { get; set; }
        public string TotalBalance { get; set; }
        public string ReturnedPercentage { get; set; }
        public string BalancePercentage { get; set; }
    }
}
