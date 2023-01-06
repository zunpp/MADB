using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class TbItemAndLoanPrice
    {
        public int ItemPkid { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public string LoanPricePerAcre { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
