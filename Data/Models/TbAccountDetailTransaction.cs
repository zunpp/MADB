using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class TbAccountDetailTransaction
    {
        public int AccountDetailPkid { get; set; }
        public string TransactionId { get; set; }
        public string BankAccountNumber { get; set; }
        public string AccountType { get; set; }
        public string TransactionType { get; set; }
        public string ChalenNumber { get; set; }
        public string Amount { get; set; }
        public string TotalBalance { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string Source { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsRecordEdited { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
