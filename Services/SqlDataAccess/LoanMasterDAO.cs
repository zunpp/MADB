using Common.Extensions;
using Model.Loan;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Services.SqlDataAccess
{
    public class LoanMasterDAO : GenericCommonExtensions<VMLoanMaster>
    {
        public dynamic GetLoanMaster(IDbCommand cmd)
        {

            cmd.CommandText = "Sp_LoanMaster_Select";
            cmd.Parameters.Clear();

            var personalInformation = GetList(cmd, true, "GetAll");

            return new { personalInformation };


        }
        protected override void ReadRecord(ref IDataReader aDataReader, ref VMLoanMaster aInfo, string prefix)
        {
            if (prefix == "GetAll")
            {
                aInfo = new VMLoanMaster()
                {
                    PersonPkid = aDataReader["PersonPKID"] != DBNull.Value ? Convert.ToInt32(aDataReader["PersonPKID"]) : 0,
                    TransactionId = aDataReader["TransactionID"] != DBNull.Value ? aDataReader["TransactionID"].ToString() : "",
                    AccountNumber = aDataReader["AccountNumber"] != DBNull.Value ? aDataReader["AccountNumber"].ToString() : "",
                    AccountType = aDataReader["AccountType"] != DBNull.Value ? aDataReader["AccountType"].ToString() : "",
                    Name = aDataReader["Name"] != DBNull.Value ? aDataReader["Name"].ToString() : "",
                    Nrc = aDataReader["NRC"] != DBNull.Value ? aDataReader["NRC"].ToString() : "",

                    DateOfBirth = aDataReader["DateOfBirth"] != DBNull.Value ? aDataReader["DateOfBirth"].ToString() : "",
                    FatherName = aDataReader["FatherName"] != DBNull.Value ? aDataReader["FatherName"].ToString() : "",
                    Occupation = aDataReader["Occupation"] != DBNull.Value ? aDataReader["Occupation"].ToString() : "",
                    Address = aDataReader["Address"] != DBNull.Value ? aDataReader["Address"].ToString() : "",
                    RegionId = aDataReader["RegionId"] != DBNull.Value ? aDataReader["RegionId"].ToString() : "",
                    TownshipId = aDataReader["TownshipId"] != DBNull.Value ? aDataReader["TownshipId"].ToString() : "",
                    Phone = aDataReader["Phone"] != DBNull.Value ? aDataReader["Phone"].ToString() : "",
                    StateDivisionId = aDataReader["StateDivisionID"] != DBNull.Value ? aDataReader["StateDivisionID"].ToString() : "",
                    RegistrationDate = aDataReader["RegistrationDate"] != DBNull.Value ? aDataReader["RegistrationDate"].ToString() : "",
                    IsActive = aDataReader["IsActive"] != DBNull.Value ? Convert.ToBoolean(aDataReader["IsActive"]) : false,
                    PersonRecordEdited = aDataReader["PersonRecordEdited"] != DBNull.Value ? Convert.ToBoolean(aDataReader["PersonRecordEdited"]) : false,
                    CreatedBy = aDataReader["CreatedBy"] != DBNull.Value ? aDataReader["CreatedBy"].ToString() : "",
                    LoanReturnPkid = aDataReader["LoanReturnPkid"] != DBNull.Value ? Convert.ToInt32(aDataReader["LoanReturnPkid"]) : 0,
                    LoanDate = aDataReader["LoanDate"] != DBNull.Value ? aDataReader["LoanDate"].ToString() : "",
                    LoanYear = aDataReader["LoanYear"] != DBNull.Value ? aDataReader["LoanYear"].ToString() : "",
                    LoanSeason = aDataReader["LoanSeason"] != DBNull.Value ? aDataReader["LoanSeason"].ToString() : "",
                    ReturnAmount = aDataReader["ReturnAmount"] != DBNull.Value ? aDataReader["ReturnAmount"].ToString() : "",
                    Balance = aDataReader["Balance"] != DBNull.Value ? aDataReader["Balance"].ToString() : "",
                    LoanRecordDeleted = aDataReader["LoanRecordDeleted"] != DBNull.Value ? Convert.ToBoolean(aDataReader["LoanRecordDeleted"]) : false,
                    LoanReturnEdited = aDataReader["LoanReturnEdited"] != DBNull.Value ? Convert.ToBoolean(aDataReader["LoanReturnEdited"]) : false

                };

            }
        }
    }
}
