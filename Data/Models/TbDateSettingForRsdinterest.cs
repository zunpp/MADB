using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class TbDateSettingForRsdinterest
    {
        public int DateSettingPkid { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
