﻿using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class TbInterest
    {
        public int InterestPkid { get; set; }
        public string TransactionId { get; set; }
        public string InterestRate { get; set; }
        public string Type { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public bool? IsCurrent { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsRecordEdited { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
