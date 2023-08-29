using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace FPT_Library.Models
{
	public class ApplicationUser: IdentityUser
	{
		[StringLength(35)]
		[Required]
		public string? FullName { get; set; }
		
		[StringLength(50)]
		public string? HomeAddress { get; set; }
	}
}

