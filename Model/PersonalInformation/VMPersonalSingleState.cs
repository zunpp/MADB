using System;
using System.Collections.Generic;
using System.Text;

namespace Model.PersonalInformation
{
    public class VMPersonalSingleState
    {
        public string RowIndex { get; set; }
        public string StateDivisionID { get; set; }
        public string TownshipID { get; set; }
        public int TotalRegion { get; set; }
        public int TotalPerson { get; set; }
        public decimal Amount { get; set; }
    }
}
