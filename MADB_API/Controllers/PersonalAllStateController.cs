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
    [Route("api/v{api-version:apiVersion}/PersonalAllState")]
    public class PersonalAllStateController : ControllerBase
    {
        public readonly IUnitOfWork _unitOfWork;
        public readonly MADBSolutionContext _context;
        public readonly IPersonalAllStateServices _personalAllStateServices;
        public PersonalAllStateController(IUnitOfWork unitOfWork, MADBSolutionContext context, IPersonalAllStateServices personalAllStateServices)
        {
            _unitOfWork = unitOfWork;
            _context = context;
            _personalAllStateServices = personalAllStateServices;
        }

        [HttpGet]
        [Route("GetPersonalAllState")]
        public async Task<IActionResult> GetPersonalAllState(string AccountStatus)
        {
            try
            {
                var personalAllStates = await _personalAllStateServices.GetPersonalAllState(AccountStatus);
                if (personalAllStates is StatusCodes.Status204NoContent)
                {
                    return NoContent();

                }
                else
                {
                    return Ok(personalAllStates);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet]
        [Route("GetPersonalSingleState")]
        public async Task<IActionResult> GetPersonalSingleState(string SearchItem,string AccountStatus,int PageIndex,string StateDivisionID)
        {
            try
            {
                if (SearchItem == null)
                    SearchItem = "";

                var personalSingleStates = await _personalAllStateServices.GetPersonalSingleState(SearchItem,AccountStatus,PageIndex,StateDivisionID);
                if (personalSingleStates is StatusCodes.Status204NoContent)
                {
                    return NoContent();

                }
                else
                {
                    return Ok(personalSingleStates);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet]
        [Route("GetPersonalSingleTown")]
        public async Task<IActionResult> GetPersonalSingleTown(string SearchItem, string AccountStatus, int PageIndex, string StateDivisionID,string TownName)
        {
            try
            {
                if (SearchItem == null)
                    SearchItem = "";

                var personalSingleTown = await _personalAllStateServices.GetPersonalSingleTown(SearchItem, AccountStatus, PageIndex, StateDivisionID,TownName);
                if (personalSingleTown is StatusCodes.Status204NoContent)
                {
                    return NoContent();

                }
                else
                {
                    return Ok(personalSingleTown);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpGet]
        [Route("GetPersonalSingleVillage")]
        public async Task<IActionResult> GetPersonalSingleVillage(string SearchItem, string AccountStatus, int PageIndex, string StateDivisionID, string TownName,string VillageName)
        {
            try
            {
                if (SearchItem == null)
                    SearchItem = "";

                var personalSingleVillage = await _personalAllStateServices.GetPersonalSingleVillage(SearchItem, AccountStatus, PageIndex, StateDivisionID, TownName,VillageName);
                if (personalSingleVillage is StatusCodes.Status204NoContent)
                {
                    return NoContent();

                }
                else
                {
                    return Ok(personalSingleVillage);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
