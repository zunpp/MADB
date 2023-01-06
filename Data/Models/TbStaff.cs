using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class TbStaff
    {
        public int StaffPkid { get; set; }
        public string StaffId { get; set; }
        public string Name { get; set; }
        public string Nrc { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public DateTime? JoinedDate { get; set; }
        public string Designation { get; set; }
    }
}
