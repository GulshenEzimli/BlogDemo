using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DbContexts
{
	public class BlogDbContext : DbContext
	{
        public DbSet<About> Abouts { get; set; }
        public DbSet<Article> Articles { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Comment> Comments { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Writer> Writers { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=GULSHAN;Database=BlogDb;Integrated Security=true;TrustServerCertificate=true");
		}

	}
}
