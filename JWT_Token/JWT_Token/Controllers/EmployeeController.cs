using JWT_Token.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public string GetData()
        {
            return "Authenticate with JWT";
        }
        [HttpGet]
        [Route("Details")]
        public string Details()
        {
            return "Authenticate with JWT";
        }



        [Authorize]
        [HttpPost]
        public string Adduser(Users user) 
        {
            return "User added with username" + user.Username;
             
        }

    }
}
