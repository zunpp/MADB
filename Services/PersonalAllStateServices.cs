using Data.Repository.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
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
    public class PersonalAllStateServices:IPersonalAllStateServices
    {
        public IUnitOfWork _unitOfwork;

        public ConnectionStrings _connectionStrings;
        public readonly PersonalAllStateDAO _personalAllStateDAO;
        public readonly PersonalSingleStateDAO _personalSingleStateDAO;
        public readonly PersonalSingleTownDAO _personalSingleTownDAO;
        public readonly PersonalSingleVillageDAO _personalSingleVillageDAO;
        public PersonalAllStateServices(IUnitOfWork unitOfWork, IOptions<ConnectionStrings> connectionStrings)
        {
            _unitOfwork = unitOfWork;
            _connectionStrings = connectionStrings.Value;
            _personalAllStateDAO = new PersonalAllStateDAO();
            _personalSingleStateDAO = new PersonalSingleStateDAO();
            _personalSingleTownDAO = new PersonalSingleTownDAO();
            _personalSingleVillageDAO = new PersonalSingleVillageDAO();
        }
        public async Task<dynamic> GetPersonalAllState(string AccountStatus)
        {
            try
            {
                IDbConnection connection = new SqlConnection(_connectionStrings.DefaultConnection);
                IDbConnection mycon = connection;
                IDbCommand cmd = mycon.CreateCommand();
                var personalInformations = _personalAllStateDAO.GetPersonalAllState(cmd, AccountStatus);
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
        public async Task<dynamic> GetPersonalSingleState(string SearchItem,string AccountStatus,int PageIndex,string StateDivisionID)
        {
            try
            {
                IDbConnection connection = new SqlConnection(_connectionStrings.DefaultConnection);
                IDbConnection mycon = connection;
                IDbCommand cmd = mycon.CreateCommand();
                var personalInformations = _personalSingleStateDAO.GetPersonalSingleState(cmd,SearchItem, AccountStatus,PageIndex,StateDivisionID);
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
        public async Task<dynamic> GetPersonalSingleTown(string SearchItem, string AccountStatus, int PageIndex, string StateDivisionID,string TownName)
        {
            try
            {
                IDbConnection connection = new SqlConnection(_connectionStrings.DefaultConnection);
                IDbConnection mycon = connection;
                IDbCommand cmd = mycon.CreateCommand();
                var personalInformations = _personalSingleTownDAO.GetPersonalSingleTown(cmd, SearchItem, AccountStatus, PageIndex, StateDivisionID,TownName);
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
        public async Task<dynamic> GetPersonalSingleVillage(string SearchItem, string AccountStatus, int PageIndex, string StateDivisionID, string TownName,string VillageName)
        {
            try
            {
                IDbConnection connection = new SqlConnection(_connectionStrings.DefaultConnection);
                IDbConnection mycon = connection;
                IDbCommand cmd = mycon.CreateCommand();
                var personalInformations = _personalSingleVillageDAO.GetPersonalSingleVillage(cmd, SearchItem, AccountStatus, PageIndex, StateDivisionID, TownName,VillageName);
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
