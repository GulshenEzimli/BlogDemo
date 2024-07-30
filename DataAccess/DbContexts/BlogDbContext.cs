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
        public BlogDbContext()
        {
                
        }

        public BlogDbContext(DbContextOptions<BlogDbContext> options) :base(options) 
        {
            
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Article> Articles { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Comment> Comments { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Writer> Writers { get; set; }
		public DbSet<User> Users { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }

	}
}
