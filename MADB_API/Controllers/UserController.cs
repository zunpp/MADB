using Data.Repository.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.User;
using Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_madb.Controllers
{
    //[Route("api/[controller]")]
    [ApiVersion("1.0")]
    [Route("api/v{api-version:apiVersion}/users")]
   
    public class UserController : ControllerBase
    {
        public IUnitOfWork _unitOfWork;
        public IUserServices _userServices;
        
        
        public UserController(IUnitOfWork unitOfWork, IUserServices userServices)
        {
            _unitOfWork = unitOfWork;
            _userServices = userServices;

        }
        [HttpGet]

        [AllowAnonymous]
        public async Task<IActionResult> Get(UserRequestModel requestModel)
        {
           
            try
            {
                var user = await _userServices.GetUser(requestModel);
                if (user is StatusCodes.Status204NoContent)
                {
                    return NoContent();

                }
                else
                {
                    return Ok(user);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
