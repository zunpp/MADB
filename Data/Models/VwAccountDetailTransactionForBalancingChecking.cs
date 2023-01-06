using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class VwAccountDetailTransactionForBalancingChecking
    {
        public string RegionId { get; set; }
        public string AccountNumber { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string TotalBalance { get; set; }
    }
}
