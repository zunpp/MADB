using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Base
{
   public interface ILoanServices
    {
        Task<dynamic> GetLoanReturnTransactionDetail();
        Task<dynamic> GetLoanMaster();
        Task<dynamic> GetLoanProposalList();
    }
}
