using System;
using System.Collections.Generic;
using System.Text;

namespace Model.PersonalInformation
{
    public class VMPersonalAllState
    {
        public string RowIndex { get; set; }
        public string StateDivisionID { get; set; }
        public int TotalTown { get; set; }
        public int TotalRegion { get; set; }
        public int TotalPerson { get; set; }
        public decimal Amount { get; set; }
    }
}
