using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
	public class Student
	{
		public int Id { get; set; }

		[Required]
		[UniqueName]
		public string Name { get; set; }
		public string? Domain { get;set; }
		[Required(ErrorMessage = "Email is required")]
		[EmailAddress(ErrorMessage = "Invalid email address")]
		public string Email { get; set; }
		[Required(ErrorMessage = "Phone number is required")]
		[RegularExpression(@"^\+?\d{10,10}$", ErrorMessage = "Invalid phone number")]
		public string Phone { get; set; }
	}
}
