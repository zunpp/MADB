using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class VwLoanMasterPassBookSelectByAccNo
    {
        public int LoanReturnPkid { get; set; }
        public string LoanAmount { get; set; }
        public string ReturnAmount { get; set; }
        public string TotalBalance { get; set; }
        public string Source { get; set; }
        public string LoanShortDate { get; set; }
        public DateTime? LoanDate { get; set; }
        public string TransactionType { get; set; }
    }
}
