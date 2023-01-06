using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class TbLoanTransaction
    {
        public int LoanPkid { get; set; }
        public string LoanTransactionId { get; set; }
        public string CustomerId { get; set; }
        public string TransactionType { get; set; }
        public string LoanItem { get; set; }
        public string Amount { get; set; }
        public string InterestRate { get; set; }
        public DateTime? TransactionDate { get; set; }
        public DateTime? DueDate { get; set; }
        public bool? IsDataSynced { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
