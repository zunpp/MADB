using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Base
{
    public interface IPersonalAllStateServices
    {
        Task<dynamic> GetPersonalAllState(string AccountStatus);
        Task<dynamic> GetPersonalSingleState(string SearchItem, string AccountStatus, int PageIndex, string StateDivisionID);
        Task<dynamic> GetPersonalSingleTown(string SearchItem, string AccountStatus, int PageIndex, string StateDivisionID, string TownName);
        Task<dynamic> GetPersonalSingleVillage(string SearchItem, string AccountStatus, int PageIndex, string StateDivisionID, string TownName, string VillageName);
    }
}
