using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Validations_WebApi_Csharp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Validations_WebApi_Csharp.Models;
using Validations_WebApi_Csharp.Repository;

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
        [HttpPost("create")]
        public IActionResult CreateUser([FromBody] MemoryValidations model)
        {
            var validator = new Validator();
            var validationErrors = validator.NewUserValidator(model);

            if (validationErrors.Count > 0)
            {
                return Ok(new
                {
                    status = false,
                    errormessage = validationErrors
                });
            }

            return Ok(new
            {
                status = true,
                message = "User created successfully!",
                data = model
            });
        }

    }
}
