using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class TbMessageContent
    {
        public int MessageContentPkid { get; set; }
        public string TransactionId { get; set; }
        public string MessageId { get; set; }
        public string Title { get; set; }
        public string MainContent { get; set; }
        public string AttachFileId { get; set; }
        public string IsUploaded { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
    }
}
