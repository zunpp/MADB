using Data.Models;
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
        public readonly IUnitOfWork _unitOfWork;
        public readonly IUserServices _userServices;
        public readonly MADBSolutionContext _context;
        
        
        public UserController(IUnitOfWork unitOfWork, IUserServices userServices,MADBSolutionContext context)
        {
            _unitOfWork = unitOfWork;
            _userServices = userServices;
            _context = context;

        }
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(string userName,string password)
        {
            try
            {
                var user = _context.TbUserLogin.Where(x => x.UsernameOrEmail == userName && x.Password == Helper.EncryptDecrypt.Encrypt(password, "madb") && x.Status=="Enable").FirstOrDefault();
                if(user !=null)
                {
                    return Ok(user);
                }
                else
                {
                    return BadRequest(StatusCodes.Status400BadRequest);
                }
            }
            catch(Exception ex)
            {
                return BadRequest(StatusCodes.Status500InternalServerError);
            }
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
