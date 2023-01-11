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
    public class LoanServices:ILoanServices
    {
        public IUnitOfWork _unitOfwork;

        public ConnectionStrings _connectionStrings;
        public readonly LoanReturnTransactionDetailDAO _loanReturnTransactionDetailDAO;
        public readonly LoanMasterDAO _loanMasterDAO;
        public readonly LoanProposalListDAO _loanProposalListDAO;
      
        public LoanServices(IUnitOfWork unitOfWork, IOptions<ConnectionStrings> connectionStrings)
        {
            _unitOfwork = unitOfWork;
            _connectionStrings = connectionStrings.Value;
            _loanReturnTransactionDetailDAO = new LoanReturnTransactionDetailDAO();
            _loanMasterDAO = new LoanMasterDAO();
            _loanProposalListDAO = new LoanProposalListDAO();
        }

        public async Task<dynamic> GetLoanReturnTransactionDetail()
        {
            try
            {
                IDbConnection connection = new SqlConnection(_connectionStrings.DefaultConnection);
                IDbConnection myCon = connection;
                IDbCommand cmd = myCon.CreateCommand();
                var loanReturnTransactionDetail = _loanReturnTransactionDetailDAO.GetLoanReturnTransactionDetail(cmd);
                if(loanReturnTransactionDetail !=null)
                {
                    return loanReturnTransactionDetail;
                }
                else
                {
                    return StatusCodes.Status204NoContent;
                }
            }
            catch(Exception ex)
            {
                return StatusCodes.Status500InternalServerError;
            }
        }
        public async Task<dynamic> GetLoanMaster()
        {
            try
            {
                IDbConnection connection = new SqlConnection(_connectionStrings.DefaultConnection);
                IDbConnection myCon = connection;
                IDbCommand cmd = myCon.CreateCommand();
                var loanMaster = _loanMasterDAO.GetLoanMaster(cmd);
                if (loanMaster != null)
                {
                    return loanMaster;
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
        public async Task<dynamic> GetLoanProposalList()
        {
            try
            {
                IDbConnection connection = new SqlConnection(_connectionStrings.DefaultConnection);
                IDbConnection myCon = connection;
                IDbCommand cmd = myCon.CreateCommand();
                var loanProposals = _loanProposalListDAO.GetLoanProposalList(cmd);
                if (loanProposals != null)
                {
                    return loanProposals;
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
