using System;
using System.Collections.Generic;
using System.Text;

namespace Model.PersonalInformation
{
    public class VMPersonalSingleTown
    {
        public string RowIndex { get; set; }
        public string StateDivisionID { get; set; }
        public string TownshipID { get; set; }
        public string RegionID { get; set; }
        public int TotalPerson { get; set; }
        public decimal Amount { get; set; }
    }
}
