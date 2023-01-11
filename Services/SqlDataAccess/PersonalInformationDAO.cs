using Common.Constants;
using Common.Extensions;
using Model;
using Model.PersonalInformation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Services.SqlDataAccess
{
    public class PersonalInformationDAO : GenericCommonExtensions<VMPersonalInformation>
    {
        int pageSize = 0;
        int skipCount = 0;
        public void SetPageSizeNSkipCount(BaseModel baseModel)
        {
            pageSize = SystemConstants.DEFAULT_PAGE_COUNT;//baseModel.pageSize == 0 ? SystemConstants.DEFAULT_PAGE_COUNT : baseModel.pageSize;
            //skipCount = baseModel.pageNo == 0 ? 0 : baseModel.pageNo * pageSize;
        }
        public dynamic GetPersonalInformation(IDbCommand cmd, string SearchItem, string AccountStatus, int PageIndex)
        {

            cmd.CommandText = "Sp_PersonSavingList_SelectByPaging";
            cmd.Parameters.Clear();

            //SetPageSizeNSkipCount(requestModel);
            cmd.AddParameter("@SearchItem", SearchItem);
            cmd.AddParameter("@AccountStatus", AccountStatus);
            cmd.AddParameter("@PageIndex", PageIndex);
            cmd.AddParameter("@RowsPerPage", SystemConstants.DEFAULT_PAGE_COUNT);
            //cmd.AddParameter("@pageNo", skipCount);
           // cmd.AddParameter("@orderBy", requestModel.orderBy?.Replace('$', ' ') ?? "UserPkid desc");


            IDbDataParameter cmdTotalCount = cmd.CreateParameter();
            cmdTotalCount.Direction = ParameterDirection.Output;
            cmdTotalCount.ParameterName = "@RecordCount";           
            cmdTotalCount.DbType = System.Data.DbType.Int32;
            cmdTotalCount.Size = 50;
            cmd.Parameters.Add(cmdTotalCount);
            IDbDataParameter cmdPages = cmd.CreateParameter();
            cmdPages.Direction = ParameterDirection.Output;
            cmdPages.ParameterName = "@Pages";
            cmdPages.DbType = System.Data.DbType.Int32;
            cmdPages.Size = 50;
            cmd.Parameters.Add(cmdPages);

            var personalInformation = GetList(cmd, true, "GetAll");
            var totalCount = cmdTotalCount.Value;
            var pages = cmdPages.Value;
            return new { personalInformation, totalCount,pages };


        }


        protected override void ReadRecord(ref IDataReader aDataReader, ref VMPersonalInformation aInfo, string prefix)
        {
            if (prefix == "GetAll")
            {
                aInfo = new VMPersonalInformation()
                {
                    RowIndex = aDataReader["RowIndex"] != DBNull.Value ? aDataReader["RowIndex"].ToString() : "",
                    AccountNumber = aDataReader["AccountNumber"] != DBNull.Value ? aDataReader["AccountNumber"].ToString() : "",
                    AccountType = aDataReader["AccountType"] != DBNull.Value ? aDataReader["AccountType"].ToString() : "",
                    Name = aDataReader["Name"] != DBNull.Value ? aDataReader["Name"].ToString() : "",
                    FatherName = aDataReader["FatherName"] != DBNull.Value ? aDataReader["FatherName"].ToString() : "",
                    Amount = aDataReader["Amount"] != DBNull.Value ? aDataReader["Amount"].ToString() : ""
                };

            }


        }
    }
}
