using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PersonalityTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalityTest.Data
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}
		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
		}
		public DbSet<SectionA> sectionAs { get; set; }
		public DbSet<SectionB> sectionBs { get; set; }
		public DbSet<SectionC> sectionCs { get; set; }
		public DbSet<SectionD> sectionDs { get; set; }
		public DbSet<SectionE> sectionEs { get; set; }
		public DbSet<SectionF> sectionFs { get; set; }
		public DbSet<SectionG> sectionGs { get; set; }
	}
}
