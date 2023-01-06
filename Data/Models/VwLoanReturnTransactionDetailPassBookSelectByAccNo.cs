using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class VwLoanReturnTransactionDetailPassBookSelectByAccNo
    {
        public int LoanReturnTransactionDetailPkid { get; set; }
        public int LoanReturnPkid { get; set; }
        public string LoanAmount { get; set; }
        public string ReturnAmount { get; set; }
        public string InterestAmount { get; set; }
        public string FineInterestAmount { get; set; }
        public string SavingAmount { get; set; }
        public string TotalBalance { get; set; }
        public string Source { get; set; }
        public string ReturnShortDate { get; set; }
        public string ReturnDate { get; set; }
        public string TransactionType { get; set; }
    }
}
