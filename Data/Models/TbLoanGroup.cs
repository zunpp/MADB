using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class TbLoanGroup
    {
        public int LoanGroupPkid { get; set; }
        public string TransactionId { get; set; }
        public string FirstAccount { get; set; }
        public string SecondAccount { get; set; }
        public string ThirdAccount { get; set; }
    }
}
