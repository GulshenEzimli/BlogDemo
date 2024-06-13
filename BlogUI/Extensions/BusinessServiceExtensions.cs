using Business.Abstract;
using Business.Concrete;

namespace BlogUI.Extensions
{
	public static class BusinessServiceExtensions
	{
		public static void AddBusinessServices(this IServiceCollection services)
		{
			services.AddTransient<IArticleService, ArticleManager>();
			services.AddTransient<ICategoryService, CategoryManager>();
			services.AddTransient<ICommentService, CommentManager>();
			services.AddTransient<INewsLetterService, NewsLetterManager>();
            services.AddTransient<IAboutService, AboutManager>();
			services.AddTransient<IContactService, ContactManager>();
		}
	}
}
