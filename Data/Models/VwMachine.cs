using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class VwMachine
    {
        public int MachinePkid { get; set; }
        public string MachineId { get; set; }
        public string Manufacturer { get; set; }
        public string MachineType { get; set; }
    }
}
