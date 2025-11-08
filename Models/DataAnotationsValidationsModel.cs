using System.ComponentModel.DataAnnotations;

namespace Validations_WebApi_Csharp.Models
{
    public class DataAnotationsValidationsModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(25, ErrorMessage = "Name can't exceed 100 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [Range(18, 60, ErrorMessage = "Age must be between 18 and 60.")]
        public int Age { get; set; }
    }
}
