using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class VwAccountDetailTransactionPassBookSelectByAccNo
    {
        public int AccountDetailPkid { get; set; }
        public string Amount { get; set; }
        public string TotalBalance { get; set; }
        public string Source { get; set; }
        public string TransactionShortDate { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string TransactionType { get; set; }
    }
}
