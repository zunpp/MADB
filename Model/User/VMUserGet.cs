using System;
using System.Collections.Generic;
using System.Text;

namespace Model.User
{
   public  class VMUserGet
    {
        public int UserPkid { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }

        public string Role { get; set; }

        // public string UploadedImage { get; set; }
        public int StateDivision { get; set; }

        public DateTime CreatedDate { get; set; }
        public int TownshipId { get; set; }
        public string Status { get; set; }
    }
}
