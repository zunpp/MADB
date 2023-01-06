using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class VwInterest
    {
        public int InterestPkid { get; set; }
        public string TransactionId { get; set; }
        public string InterestRate { get; set; }
        public string Type { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public bool? IsCurrent { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsRecordEdited { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
