using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Validators
{
    public class DataCheckAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var datetime = (DateTime?)value;

            if (datetime < DateTime.Now)
            {
                return new ValidationResult("The date must be greater than or equal than todays date.");
            }
                
            return ValidationResult.Success;

        }
    }
}
