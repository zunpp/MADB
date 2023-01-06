using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class TbJoinAccount
    {
        public int JoinAccountPkid { get; set; }
        public string TransactionId { get; set; }
        public string FirstAccountOwnerPkid { get; set; }
        public string SecondAccountOwnerPkid { get; set; }
        public bool? IsActive { get; set; }
    }
}
