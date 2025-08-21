using System.ComponentModel.DataAnnotations;
using WebApi.Data;

namespace WebApi
{
	public class UniqueNameAttribute : ValidationAttribute
	{
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			var context = (StudentDbContext)validationContext.GetService(typeof(StudentDbContext));
			var entity = context.Students.SingleOrDefault(e => e.Name == value.ToString());

			if (entity != null)
			{
				return new ValidationResult("Name must be unique.");
			}

			return ValidationResult.Success;
		}
	}

}