using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class TbAccountSummary
    {
        public int AccountSummaryPkid { get; set; }
        public string TransactionId { get; set; }
        public string BankAccountNumber { get; set; }
        public string AccountStatus { get; set; }
        public string LastBalance { get; set; }
        public string AmountUpdatedDate { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsRecordEdited { get; set; }
        public string RecordCreatedBy { get; set; }
        public DateTime? RecordCreatedDate { get; set; }
    }
}
