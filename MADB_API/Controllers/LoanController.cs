using Data.Models;
using Data.Repository.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_madb.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{api-version:apiVersion}/Loan")]
    public class LoanController : ControllerBase
    {
        public readonly IUnitOfWork _unitOfWork;
        public readonly MADBSolutionContext _context;
        public readonly ILoanServices _loanServices;
        public LoanController(IUnitOfWork unitOfWork, MADBSolutionContext context, ILoanServices loanServices)
        {
            _unitOfWork = unitOfWork;
            _context = context;
            _loanServices = loanServices;
        }

        [HttpGet]
        [Route("GetLoanReturnTransactionDetail")]
        public async Task<IActionResult> GetLoanReturnTransactionDetail()
        {
            try
            {
                var loanReturnTransactionDetail =await _loanServices.GetLoanReturnTransactionDetail();
                if(loanReturnTransactionDetail is StatusCodes.Status204NoContent)
                {
                    return NoContent();
                }
                else
                {
                    return Ok(loanReturnTransactionDetail);
                }
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpGet]
        [Route("GetLoanMaster")]
        public async Task<IActionResult> GetLoanMaster()
        {
            try
            {
                var loanMaster = await _loanServices.GetLoanMaster();
                if (loanMaster is StatusCodes.Status204NoContent)
                {
                    return NoContent();
                }
                else
                {
                    return Ok(loanMaster);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpGet]
        [Route("GetLoanProposalList")]
        public async Task<IActionResult> GetLoanProposalList()
        {
            try
            {
                var loanProposals = await _loanServices.GetLoanProposalList();
                if (loanProposals is StatusCodes.Status204NoContent)
                {
                    return NoContent();
                }
                else
                {
                    return Ok(loanProposals);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

    }
}
