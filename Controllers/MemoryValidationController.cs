using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Validations_WebApi_Csharp.Models;
using Validations_WebApi_Csharp.Repository;

namespace Validations_WebApi_Csharp.Controllers
{
    public class MemoryValidationController : Controller
    {
        [ApiController]
        [Route("api/[controller]")]
        public class UserController : ControllerBase
        {
            //[HttpPost("create")]
            //public IActionResult CreateUser([FromBody] MemoryValidations model)
            //{
            //    var validator = new Validator();
            //    var validationErrors = validator.NewUserValidator(model);

            //    if (validationErrors.Count > 0)
            //    {
            //        return BadRequest(new
            //        {
            //            status = false,
            //            errormessage = validationErrors
            //        });
            //    }

            //    return Ok(new
            //    {
            //        status = true,
            //        message = "User created successfully!",
            //        data = model
            //    });
            //}
        }
    }
}
