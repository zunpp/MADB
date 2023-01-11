using Common.Constants;
using Common.Extensions;
using Model.PersonalInformation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Services.SqlDataAccess
{
    public class PersonalSingleStateDAO:GenericCommonExtensions<VMPersonalSingleState>
    {
        public dynamic GetPersonalSingleState(IDbCommand cmd, string SearchItem, string AccountStatus, int PageIndex,string StateDivisionID)
        {

            cmd.CommandText = "Sp_PersonSavingList_SelectByPagingAndSingleStateView";
            cmd.Parameters.Clear();

            //SetPageSizeNSkipCount(requestModel);
            cmd.AddParameter("@SearchItem", SearchItem);
            cmd.AddParameter("@StateDivision", StateDivisionID);
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


        protected override void ReadRecord(ref IDataReader aDataReader, ref VMPersonalSingleState aInfo, string prefix)
        {
            if (prefix == "GetAll")
            {
                aInfo = new VMPersonalSingleState()
                {
                    RowIndex = aDataReader["RowIndex"] != DBNull.Value ? aDataReader["RowIndex"].ToString() : "",
                    StateDivisionID = aDataReader["StateDivisionID"] != DBNull.Value ? aDataReader["StateDivisionID"].ToString() : "",
                    TownshipID = aDataReader["TownshipID"] != DBNull.Value ? aDataReader["TownshipID"].ToString() : "",
                    TotalRegion = aDataReader["TotalRegion"] != DBNull.Value ? Convert.ToInt32(aDataReader["TotalRegion"]) : 0,
                    TotalPerson = aDataReader["TotalPerson"] != DBNull.Value ? Convert.ToInt32(aDataReader["TotalPerson"]) : 0,
                    Amount = aDataReader["Amount"] != DBNull.Value ? Convert.ToDecimal(aDataReader["Amount"]) : 0
                };

            }


        }
    }
}
