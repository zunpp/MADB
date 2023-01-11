using System;
using System.Collections.Generic;
using System.Text;

namespace Model.PersonalInformation
{
    public class VMPersonalSingleVillage
    {
        public string RowIndex { get; set; }
        public string StateDivisionID { get; set; }
        public string TownshipID { get; set; }
        public string RegionID { get; set; }
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string NRC { get; set; }
        public string LastTransDate { get; set; }
        public decimal Amount { get; set; }
    }
}

