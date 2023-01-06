using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class TbSavingMaster
    {
        public int SavingMasterPkid { get; set; }
        public string TransactionId { get; set; }
        public string CustomerId { get; set; }
        public string SavingAmount { get; set; }
        public string TotalInterest { get; set; }
        public string TotalAmount { get; set; }
    }
}
