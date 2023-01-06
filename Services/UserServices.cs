using Data.Repository.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using Model.User;
using Services.Base;
using Services.Options;
using Services.SqlDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
   public class UserServices:IUserServices
    {
        public IUnitOfWork _unitOfwork;
    
        public ConnectionStrings _connectionStrings;
        public readonly UserDAO _userDAO;
        public UserServices(IUnitOfWork unitOfWork, IOptions<ConnectionStrings> connectionStrings)
        {
            _unitOfwork = unitOfWork;
            _connectionStrings = connectionStrings.Value;
            _userDAO = new UserDAO();
        }
        public async Task<dynamic> GetUser(UserRequestModel requestModel)
        {
 
            try
            {
                IDbConnection connection = new SqlConnection(_connectionStrings.DefaultConnection);
                IDbConnection mycon = connection;
                IDbCommand cmd = mycon.CreateCommand();
                var user = _userDAO.GetUser(cmd, requestModel);
                if (user != null)
                {
                   
                    return user;
                }
                else
                {
                  
                    return StatusCodes.Status204NoContent;
                }
            }
            catch (Exception ex)
            {
             
                return StatusCodes.Status500InternalServerError;
            }


        }
    }
}
