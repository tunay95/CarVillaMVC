using Carvilla.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Carvilla.DAL
{
	public class AppDbContext : IdentityDbContext<AppUser>
	{
		public AppDbContext(DbContextOptions options) : base(options){ }
		 public DbSet<Service> Services { get; set; }
	}
}
