using Data.Repository.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using Model.PersonalInformation;
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
    public class PersonalInformationServices:IPersonalInformationServices
    {
        public IUnitOfWork _unitOfwork;

        public ConnectionStrings _connectionStrings;
        public readonly PersonalInformationDAO _personalInformationDAO;
        public PersonalInformationServices(IUnitOfWork unitOfWork,IOptions<ConnectionStrings> connectionStrings)
        {
            _unitOfwork = unitOfWork;
            _connectionStrings = connectionStrings.Value;
            _personalInformationDAO = new PersonalInformationDAO();
        }
        public async Task<dynamic> GetPersonalInformation(string SearchItem, string AccountStatus, int PageIndex)
        {
            try
            {
                IDbConnection connection = new SqlConnection(_connectionStrings.DefaultConnection);
                IDbConnection mycon = connection;
                IDbCommand cmd = mycon.CreateCommand();
                var personalInformations =_personalInformationDAO.GetPersonalInformation(cmd, SearchItem, AccountStatus, PageIndex);
                if (personalInformations != null)
                {

                    return personalInformations;
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
