using Common.Constants;
using Common.Extensions;
using Model.PersonalInformation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Services.SqlDataAccess
{
    public class PersonalSingleVillageDAO:GenericCommonExtensions<VMPersonalSingleVillage>
    {
        public dynamic GetPersonalSingleVillage(IDbCommand cmd, string SearchItem, string AccountStatus, int PageIndex, string StateDivisionID, string TownName,string VillageName)
        {

            cmd.CommandText = "Sp_PersonSavingList_SelectByPagingAndSingleVillageView";
            cmd.Parameters.Clear();

            //SetPageSizeNSkipCount(requestModel);
            cmd.AddParameter("@SearchItem", SearchItem);
            cmd.AddParameter("@StateDivision", StateDivisionID);
            cmd.AddParameter("@TownName", TownName);
            cmd.AddParameter("@VillageName", VillageName);
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
            return new { personalInformation, totalCount, pages };


        }


        protected override void ReadRecord(ref IDataReader aDataReader, ref VMPersonalSingleVillage aInfo, string prefix)
        {
            if (prefix == "GetAll")
            {
                aInfo = new VMPersonalSingleVillage()
                {
                    RowIndex = aDataReader["RowIndex"] != DBNull.Value ? aDataReader["RowIndex"].ToString() : "",
                    StateDivisionID = aDataReader["StateDivisionID"] != DBNull.Value ? aDataReader["StateDivisionID"].ToString() : "",
                    TownshipID = aDataReader["TownshipID"] != DBNull.Value ? aDataReader["TownshipID"].ToString() : "",
                    RegionID = aDataReader["RegionID"] != DBNull.Value ? aDataReader["RegionID"].ToString() : "",
                    AccountNumber = aDataReader["AccountNumber"] != DBNull.Value ?aDataReader["AccountNumber"].ToString() : "",
                    AccountType = aDataReader["AccountType"] != DBNull.Value ? aDataReader["AccountType"].ToString() : "",
                    Name = aDataReader["Name"] != DBNull.Value ? aDataReader["Name"].ToString() : "",
                    FatherName= aDataReader["FatherName"] != DBNull.Value ? aDataReader["FatherName"].ToString() : "",
                    NRC= aDataReader["NRC"] != DBNull.Value ? aDataReader["NRC"].ToString() : "",
                    LastTransDate= aDataReader["LastTransDate"] != DBNull.Value ? aDataReader["LastTransDate"].ToString() : "",
                    Amount= aDataReader["Amount"] != DBNull.Value ? Convert.ToDecimal(aDataReader["Amount"]) : 0

                };

            }


        }
    }
}
