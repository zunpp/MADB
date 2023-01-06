using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class TbMoeKyoInterestTransaction
    {
        public int MoeKyoInterestPkid { get; set; }
        public string TransactionId { get; set; }
        public string BankAccountNumber { get; set; }
        public string TownshipId { get; set; }
        public string RegionId { get; set; }
        public string StateDivisionId { get; set; }
        public string LoanStartDate { get; set; }
        public string LoanYear { get; set; }
        public string LoanSeason { get; set; }
        public string LoanAmount { get; set; }
        public string ReturnAmount { get; set; }
        public string InterestRate { get; set; }
        public string InterestAmount { get; set; }
        public string InterestCalculationDate { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsRecordEdited { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
