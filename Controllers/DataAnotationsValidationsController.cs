using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Validations_WebApi_Csharp.Models;


namespace Validations_WebApi_Csharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataAnotationsValidationsController : ControllerBase
    {
        [HttpPost]

        public IActionResult NewUser([FromBody] DataAnotationsValidationsModel UserData)
        {
            if(!ModelState.IsValid)
            {
              return BadRequest(ModelState);
            }
            return Ok(new {message = "New User Created SUcesfully....!"});
        }

    }
}
