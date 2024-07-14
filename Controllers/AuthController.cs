using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_RPG.Data;
using dotnet_RPG.DTO.User;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_RPG.Controllers
{
     [ApiController]
    [Route("api/Auth")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repository;

        public AuthController(IAuthRepository repository)
        {
            _repository = repository;
        }

        [HttpPost("Register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterDTO request)
        {
            var response = await _repository.Register(
                new User{ Username = request.Username}, request.Password
            );

            if(!response.Success){
                return BadRequest(response);
            }
            return Ok(response);
        }


         [HttpPost("Login")]
         public async Task<ActionResult<ServiceResponse<int>>> Login(UserLoginDTO request)
        {
            var response = await _repository.Login(request.Username, request.Password);

            if(!response.Success){
                return BadRequest(response);
            }
            return Ok(response);
        }


        // END
    }
}