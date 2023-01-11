using System;
using System.Collections.Generic;
using System.Text;

namespace Model.PersonalInformation
{
    public class VMPersonalRequestModel:BaseModel
    {
        public string SearchItem { get; set; }
        public string AccountStatus { get; set; }
        public int PageIndex { get; set; }
    }
}
