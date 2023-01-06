using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class VwLoanMasterOnlineCheck
    {
        public int LoanReturnPkid { get; set; }
        public string TransactionId { get; set; }
        public string BankAccountNumber { get; set; }
        public string LoanYear { get; set; }
        public string LoanSeason { get; set; }
        public string LoanAmount { get; set; }
        public DateTime? LoanDate { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsRecordEdited { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
