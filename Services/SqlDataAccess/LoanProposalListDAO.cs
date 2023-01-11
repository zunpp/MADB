using Common.Extensions;
using Model.Loan;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Services.SqlDataAccess
{
   public class LoanProposalListDAO:GenericCommonExtensions<VMLoanProposalList>
    {
        public dynamic GetLoanProposalList(IDbCommand cmd)
        {

            cmd.CommandText = "Sp_LoanProposal_Select";
            cmd.Parameters.Clear();

            var personalInformation = GetList(cmd, true, "GetAll");

            return new { personalInformation };


        }
        protected override void ReadRecord(ref IDataReader aDataReader, ref VMLoanProposalList aInfo, string prefix)
        {
            if (prefix == "GetAll")
            {
                aInfo = new VMLoanProposalList()
                {
                    ApplyPkid = aDataReader["ApplyPkid"] != DBNull.Value ? Convert.ToInt32(aDataReader["ApplyPkid"]) : 0,
                    TransactionId = aDataReader["TransactionID"] != DBNull.Value ? aDataReader["TransactionID"].ToString() : "",
                    BankAccountNumber = aDataReader["BankAccountNumber"] != DBNull.Value ? aDataReader["BankAccountNumber"].ToString() : "",
                    Name = aDataReader["Name"] != DBNull.Value ? aDataReader["Name"].ToString() : "",
                    Nrc = aDataReader["NRC"] != DBNull.Value ? aDataReader["NRC"].ToString() : "",

                    FatherName = aDataReader["FatherName"] != DBNull.Value ? aDataReader["FatherName"].ToString() : "",
                    RegionId = aDataReader["RegionId"] != DBNull.Value ? aDataReader["RegionId"].ToString() : "",
                    TownshipId = aDataReader["TownshipId"] != DBNull.Value ? aDataReader["TownshipId"].ToString() : "",
                    Phone = aDataReader["Phone"] != DBNull.Value ? aDataReader["Phone"].ToString() : "",
                    StateDivisionId = aDataReader["StateDivisionID"] != DBNull.Value ? aDataReader["StateDivisionID"].ToString() : "",
                    ApplyDate= aDataReader["ApplyDate"] != DBNull.Value ? aDataReader["ApplyDate"].ToString() : "",
                    ApplyStatus = aDataReader["ApplyStatus"] != DBNull.Value ? aDataReader["ApplyStatus"].ToString() : "",
                    QueueNumber = aDataReader["QueueNumber"] != DBNull.Value ? aDataReader["QueueNumber"].ToString() : "",
                    LoanName= aDataReader["LoanName"] != DBNull.Value ? aDataReader["LoanName"].ToString() : "",
                    LoanAmount= aDataReader["LoanAmount"] != DBNull.Value ? aDataReader["LoanAmount"].ToString() : "",
                    IsDeleted= aDataReader["IsDeleted"] != DBNull.Value ? Convert.ToBoolean(aDataReader["IsDeleted"]) : false,
                    CreatedBy = aDataReader["CreatedBy"] != DBNull.Value ? aDataReader["CreatedBy"].ToString() : "",

                };

            }
        }
    }
}
