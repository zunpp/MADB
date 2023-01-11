using Model.PersonalInformation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Base
{
    public interface IPersonalInformationServices
    {
        Task<dynamic> GetPersonalInformation(string SearchItem,string AccountStatus,int PageIndex);
    }
}
