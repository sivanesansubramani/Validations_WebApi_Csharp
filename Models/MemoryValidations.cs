using Validations_WebApi_Csharp.Enums;

namespace Validations_WebApi_Csharp.Models
{
    public class MemoryValidations
    {
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public RolesEnom? Role { get; set; }
        public decimal? Salary { get; set; }
        public string? Password { get; set; }
    }

    public class ErrorDetails
    {
        public string PropertyName { get; set; }
        public string ErrorMessage { get;set; }
        public string ErrorIdentifier { get; set; } 
    }

  
}
