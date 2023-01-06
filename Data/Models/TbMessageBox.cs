using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class TbMessageBox
    {
        public int MessagePkid { get; set; }
        public string TransactionId { get; set; }
        public string MessageId { get; set; }
        public string MessageTo { get; set; }
        public string MessageFrom { get; set; }
        public string MessageStatus { get; set; }
        public DateTime? MessageDate { get; set; }
    }
}
