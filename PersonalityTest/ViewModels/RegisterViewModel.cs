using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalityTest.ViewModels
{
	public class RegisterViewModel
	{
		[Required]
		[DisplayName("Username")]
		[Column(TypeName = "nvarchar(250)")]
		public string usernames { get; set; }
		[Required]
		[Column(TypeName = "nvarchar(250)")]
		[DisplayName("Last Name")]
		public string LastNames { get; set; }
		[Required]
		[Column(TypeName = "nvarchar(250)")]
		[DisplayName("First Name")]
		public string FirstNames { get; set; }

		[Required]
		[DisplayName("HomeAddress")]
		public string HomeAddress { get; set; }
		[Required]
		[DataType(DataType.EmailAddress)]
		[DisplayName("Email")]
		public string Email { get; set; }

		[Required]
		[StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 8)]
		[DataType(DataType.Password)]
		[Display(Name = "Password")]
		public string Password { get; set; }

		[DataType(DataType.Password)]
		[Display(Name = "Confirm password")]
		[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
		public string ConfirmPassword { get; set; }

		[Required(AllowEmptyStrings = false)]
		[DataType(DataType.Date)]
		[Display(Name = "Date of Birth")]
		public DateTime Dob { get; set; }
		[Required]
		[DataType(DataType.PhoneNumber)]
		public string PhoneNumber { get; set; }
	}
}
