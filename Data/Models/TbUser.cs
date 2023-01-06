using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class TbUser
    {
        public int UserPkid { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public int StateDivisionId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string TownshipId { get; set; }
        public string Status { get; set; }
    }
}
