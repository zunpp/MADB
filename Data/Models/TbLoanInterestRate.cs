using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class TbLoanInterestRate
    {
        public int LoanInterestRatePkid { get; set; }
        public string TransactionId { get; set; }
        public string LoanYear { get; set; }
        public string LoanSeason { get; set; }
        public string InterestRate { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsRecordEdited { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
