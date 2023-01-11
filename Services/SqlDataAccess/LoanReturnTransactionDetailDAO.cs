using Common.Extensions;
using Model.Loan;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Services.SqlDataAccess
{
    public class LoanReturnTransactionDetailDAO: GenericCommonExtensions<VMLoanReturnTransactionDetailModel>
    {
        public dynamic GetLoanReturnTransactionDetail(IDbCommand cmd)
        {

            cmd.CommandText = "Sp_LoanReturnTransactionDetail_Select";
            cmd.Parameters.Clear();
           
            var personalInformation = GetList(cmd, true, "GetAll");

            return new { personalInformation };


        }


        protected override void ReadRecord(ref IDataReader aDataReader, ref VMLoanReturnTransactionDetailModel aInfo, string prefix)
        {
            if (prefix == "GetAll")
            {
                aInfo = new VMLoanReturnTransactionDetailModel()
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
                    IsDeleted = aDataReader["IsDeleted"] != DBNull.Value ? Convert.ToBoolean(aDataReader["IsDeleted"]) : false,
                    PersonRecordEdited = aDataReader["PersonRecordEdited"] != DBNull.Value ? Convert.ToBoolean(aDataReader["PersonRecordEdited"]) : false,
                    CreatedBy = aDataReader["CreatedBy"] != DBNull.Value ? aDataReader["CreatedBy"].ToString() : "",
                    CreatedDate = aDataReader["CreatedDate"] != DBNull.Value ? Convert.ToDateTime(aDataReader["CreatedDate"]) : DateTime.Now,
                    LoanReturnTransactionDetailPkid = aDataReader["LoanReturnTransactionDetailPkid"] != DBNull.Value ? Convert.ToInt32(aDataReader["LoanReturnTransactionDetailPkid"]) : 0,
                    LoanReturnPkid = aDataReader["LoanReturnPkid"] != DBNull.Value ? Convert.ToInt32(aDataReader["LoanReturnPkid"]) : 0,
                    LoanDate = aDataReader["LoanDate"] != DBNull.Value ? aDataReader["LoanDate"].ToString() : "",
                    LoanYear = aDataReader["LoanYear"] != DBNull.Value ? aDataReader["LoanYear"].ToString() : "",
                    LoanSeason = aDataReader["LoanSeason"] != DBNull.Value ? aDataReader["LoanSeason"].ToString() : "",
                    SerialNumber = aDataReader["SerialNumber"] != DBNull.Value ? aDataReader["SerialNumber"].ToString() : "",
                    ChalenNumber = aDataReader["ChalenNumber"] != DBNull.Value ? aDataReader["ChalenNumber"].ToString() : "",
                    ReturnAmount = aDataReader["ReturnAmount"] != DBNull.Value ? aDataReader["ReturnAmount"].ToString() : "",
                    InterestAmount = aDataReader["InterestAmount"] != DBNull.Value ? aDataReader["InterestAmount"].ToString() : "",
                    FineInterestAmount = aDataReader["FineInterestAmount"] != DBNull.Value ? aDataReader["FineInterestAmount"].ToString() : "",
                    ProfitSavingAmount = aDataReader["ProfitSavingAmount"] != DBNull.Value ? aDataReader["ProfitSavingAmount"].ToString() : "",
                    SavingAmount = aDataReader["SavingAmount"] != DBNull.Value ? aDataReader["SavingAmount"].ToString() : "",
                    ShareAmount = aDataReader["ShareAmount"] != DBNull.Value ? aDataReader["ShareAmount"].ToString() : "",
                    FormPrice = aDataReader["FormPrice"] != DBNull.Value ? aDataReader["FormPrice"].ToString() : "",
                    Other = aDataReader["Other"] != DBNull.Value ? aDataReader["Other"].ToString() : "",
                    TotalAmount = aDataReader["TotalAmount"] != DBNull.Value ? aDataReader["TotalAmount"].ToString() : "",
                    ReturnDate = aDataReader["ReturnDate"] != DBNull.Value ? aDataReader["ReturnDate"].ToString() : "",
                    ReturnTransactionDeleted = aDataReader["ReturnTransactionDeleted"] != DBNull.Value ? Convert.ToBoolean(aDataReader["ReturnTransactionDeleted"]) : false,
                    ReturnTransactionEdited = aDataReader["ReturnTransactionEdited"] != DBNull.Value ? Convert.ToBoolean(aDataReader["ReturnTransactionEdited"]) : false,
                    ReturnTransactionCreatedBy = aDataReader["ReturnTransactionCreatedBy"] != DBNull.Value ? aDataReader["ReturnTransactionCreatedBy"].ToString() : ""
                };

        }


        }
    }
}
