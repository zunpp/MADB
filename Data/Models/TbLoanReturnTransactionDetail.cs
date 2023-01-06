using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class TbLoanReturnTransactionDetail
    {
        public int LoanReturnTransactionDetailPkid { get; set; }
        public string TransactionId { get; set; }
        public int? LoanReturnPkid { get; set; }
        public string AccountNumber { get; set; }
        public string LoanYear { get; set; }
        public string LoanSeason { get; set; }
        public string SerialNumber { get; set; }
        public string ChalenNumber { get; set; }
        public string ReturnAmount { get; set; }
        public string InterestAmount { get; set; }
        public string FineInterestAmount { get; set; }
        public string ProfitSavingAmount { get; set; }
        public string SavingAmount { get; set; }
        public string ShareAmount { get; set; }
        public string FormPrice { get; set; }
        public string Other { get; set; }
        public string ReturnDate { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsRecordEdited { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
