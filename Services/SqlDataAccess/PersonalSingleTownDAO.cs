using Common.Constants;
using Common.Extensions;
using Model.PersonalInformation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Services.SqlDataAccess
{
    public class PersonalSingleTownDAO:GenericCommonExtensions<VMPersonalSingleTown>
    {
        public dynamic GetPersonalSingleTown(IDbCommand cmd, string SearchItem, string AccountStatus, int PageIndex, string StateDivisionID,string TownName)
        {

            cmd.CommandText = "Sp_PersonSavingList_SelectByPagingAndSingleTownView";
            cmd.Parameters.Clear();

            //SetPageSizeNSkipCount(requestModel);
            cmd.AddParameter("@SearchItem", SearchItem);
            cmd.AddParameter("@StateDivision", StateDivisionID);
            cmd.AddParameter("@TownName", TownName);
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


        protected override void ReadRecord(ref IDataReader aDataReader, ref VMPersonalSingleTown aInfo, string prefix)
        {
            if (prefix == "GetAll")
            {
                aInfo = new VMPersonalSingleTown()
                {
                    RowIndex = aDataReader["RowIndex"] != DBNull.Value ? aDataReader["RowIndex"].ToString() : "",
                    StateDivisionID = aDataReader["StateDivisionID"] != DBNull.Value ? aDataReader["StateDivisionID"].ToString() : "",
                    TownshipID = aDataReader["TownshipID"] != DBNull.Value ? aDataReader["TownshipID"].ToString() : "",
                    RegionID = aDataReader["RegionID"] != DBNull.Value ?aDataReader["RegionID"].ToString() : "",
                    TotalPerson = aDataReader["TotalPerson"] != DBNull.Value ? Convert.ToInt32(aDataReader["TotalPerson"]) : 0,
                    Amount = aDataReader["Amount"] != DBNull.Value ? Convert.ToDecimal(aDataReader["Amount"]) : 0
                };

            }


        }
    }
}
