using Data.Models;
using Data.Repository.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.PersonalInformation;
using Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_madb.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{api-version:apiVersion}/PersonalInformation")]
    
    public class PersonalInformationController : ControllerBase
    {
        public readonly IUnitOfWork _unitOfWork;
        public readonly MADBSolutionContext _context;
        public readonly IPersonalInformationServices _personalInformationServices;
        public PersonalInformationController(IUnitOfWork unitOfWork, MADBSolutionContext context,IPersonalInformationServices personalInformationServices)
        {
            _unitOfWork = unitOfWork;
            _context = context;
            _personalInformationServices = personalInformationServices;
        }
        [HttpGet]
        [Route("PersonSavingList_SelectByPaging")]
        public async Task<IActionResult> PersonSavingList_SelectByPaging(string SearchItem,string AccountStatus,int PageIndex)
        {
            try
            {
                if (SearchItem == null)
                    SearchItem = "";

                var personalInformations = await _personalInformationServices.GetPersonalInformation(SearchItem,AccountStatus,PageIndex);
                if (personalInformations is StatusCodes.Status204NoContent)
                {
                    return NoContent();

                }
                else
                {
                    return Ok(personalInformations);
                }
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            
        }
    }
}
