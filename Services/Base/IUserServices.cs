using Model.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Base
{
    public interface IUserServices
    {
        Task<dynamic> GetUser(UserRequestModel requestModel);
    }
}
