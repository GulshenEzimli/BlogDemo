﻿using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace BlogUI.Extensions
{
	public static class EfDbExtensions
	{
		public static void AddEfDb(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddTransient<IArticleRepository, ArticleRepository>();
			services.AddTransient<ICategoryRepository, CategoryRepository>();
			services.AddTransient<ICommentRepository, CommentRepository>();
			services.AddTransient<INewsLetterRepository, NewsLetterRepository>();
            services.AddTransient<IAboutRepository, AboutRepository>(); 
			services.AddTransient<IContactRepository, ContactRepository>();
		}
	}
}
