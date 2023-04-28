using Microsoft.AspNetCore.Identity;
using SalesOrdersApp.Models.DomainModels;

namespace SalesOrdersApp.Models.ViewModels
{
	public class UserViewModel
	{
		public IEnumerable<User> Users { get; set; } = null!;
		public IEnumerable<IdentityRole> Roles { get; set; } = null!;
    }
}
