using EAMS.Models;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EAMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        // GET: api/<LoginController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<LoginController>/5
        //[HttpGet("{Username}/{Password}")]
        [HttpGet]
        public ActionResult Login(LoginModel login)
        {
            if(login.Username.ToLower() == "minesh" || login.Password == "minesh")
            {
                return Ok("Login Successfull");
            }
            return Unauthorized();
        }

        // POST api/<LoginController>
        //[HttpPost]
        //public void Post(string Username, string Password)
        //{
        //}

        //// PUT api/<LoginController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<LoginController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
