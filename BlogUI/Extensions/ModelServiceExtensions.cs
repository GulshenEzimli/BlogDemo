using BlogUI.Services.Implementations;
using BlogUI.Services.Interfaces;

namespace BlogUI.Extensions
{
	public static class ModelServiceExtensions
	{
		public static void AddModelServices(this IServiceCollection services)
		{
			services.AddTransient<IArticleModelService, ArticleModelService>();
			services.AddTransient<ICategoryModelService, CategoryModelService>();
			services.AddTransient<INewsLetterModelService, NewsLetterModelService>();
            services.AddTransient<IAboutModelService, AboutModelService>(); 
		}
	}
}
