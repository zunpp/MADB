using Common.Constants;
using Common.Extensions;
using Model.PersonalInformation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Services.SqlDataAccess
{
    public class PersonalAllStateDAO: GenericCommonExtensions<VMPersonalAllState>
    {
        public dynamic GetPersonalAllState(IDbCommand cmd,string AccountStatus)
        {

            cmd.CommandText = "Sp_PersonSavingList_SelectByPagingAndAllStateView";
            cmd.Parameters.Clear();

            cmd.AddParameter("@AccountStatus", AccountStatus);          
            var personalInformation = GetList(cmd, true, "GetAll");
            
            return new { personalInformation };


        }


        protected override void ReadRecord(ref IDataReader aDataReader, ref VMPersonalAllState aInfo, string prefix)
        {
            if (prefix == "GetAll")
            {
                aInfo = new VMPersonalAllState()
                {
                    RowIndex = aDataReader["RowIndex"] != DBNull.Value ? aDataReader["RowIndex"].ToString() : "",
                    StateDivisionID = aDataReader["StateDivisionID"] != DBNull.Value ? aDataReader["StateDivisionID"].ToString() : "",
                    TotalTown = aDataReader["TotalTown"] != DBNull.Value ? Convert.ToInt32(aDataReader["TotalTown"]) : 0,
                    TotalRegion = aDataReader["TotalRegion"] != DBNull.Value ? Convert.ToInt32(aDataReader["TotalRegion"]) : 0,
                    TotalPerson = aDataReader["TotalPerson"] != DBNull.Value ? Convert.ToInt32(aDataReader["TotalPerson"]) : 0,
                    Amount = aDataReader["Amount"] != DBNull.Value ?Convert.ToDecimal(aDataReader["Amount"]) : 0
                };

            }


        }
    }
}
