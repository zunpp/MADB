using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class TbForm7
    {
        public int Form7Pkid { get; set; }
        public int? PersonPkid { get; set; }
        public string AccountNumber { get; set; }
        public string Township { get; set; }
        public string FarmLocation { get; set; }
        public string FarmNo { get; set; }
        public string FarmName { get; set; }
        public string UpaingNo { get; set; }
        public string FarmType { get; set; }
        public string FarmArea { get; set; }
        public string ConfirmLetterNo { get; set; }
        public string ConfirmLetterDate { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsRecordEdited { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
