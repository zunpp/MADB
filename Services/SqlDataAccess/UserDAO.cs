using Common.Constants;
using Common.Extensions;
using Model;
using Model.User;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Services.SqlDataAccess
{
    public class UserDAO : GenericCommonExtensions<VMUserGet>
    {
        int pageSize = 0;
        int skipCount = 0;
        public void SetPageSizeNSkipCount(BaseModel baseModel)
        {
            pageSize = SystemConstants.DEFAULT_PAGE_COUNT;// baseModel.pageSize == 0 ? SystemConstants.DEFAULT_PAGE_COUNT : baseModel.pageSize;
            skipCount = 0;// baseModel.pageNo == 0 ? 0 : baseModel.pageNo * pageSize;
        }
        public dynamic GetUser(IDbCommand cmd,UserRequestModel requestModel)
        {
           
            cmd.CommandText = "SP_GetUsers";
            cmd.Parameters.Clear();

            SetPageSizeNSkipCount(requestModel);

            cmd.AddParameter("@pageSize", pageSize);
            cmd.AddParameter("@pageNo", skipCount);
            //cmd.AddParameter("@orderBy", requestModel.orderBy?.Replace('$', ' ') ?? "UserPkid desc");


            IDbDataParameter cmdTotalCount = cmd.CreateParameter();
            cmdTotalCount.Direction = ParameterDirection.Output;
            cmdTotalCount.ParameterName = "@totalCount";
            cmdTotalCount.DbType = System.Data.DbType.Int32;
            cmdTotalCount.Size = 50;
            cmd.Parameters.Add(cmdTotalCount);

            var userResult = GetList(cmd, true, "GetAll");
            var totalCount = cmdTotalCount.Value;
            return new { userResult, totalCount };


        }
        protected override void ReadRecord(ref IDataReader aDataReader, ref VMUserGet aInfo, string prefix)
        {
            if (prefix == "GetAll")
            {
                aInfo = new VMUserGet()
                {
                    UserPkid = aDataReader["UserPkid"] != DBNull.Value ? Convert.ToInt32(aDataReader["UserPkid"]) : 0,
                    UserName = aDataReader["UserName"] != DBNull.Value ? aDataReader["UserName"].ToString() : "",
                    Password = aDataReader["Password"] != DBNull.Value ? aDataReader["Password"].ToString() : "",
                    Role = aDataReader["Role"] != DBNull.Value ? aDataReader["Role"].ToString() : ""
                };
               
            }
           

        }
    }
}
