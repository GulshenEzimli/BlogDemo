using BlogUI.Mappers.Implementations;
using BlogUI.Mappers.Interfaces;

namespace BlogUI.Extensions
{
	public static class MapperExtensions
	{
		public static void AddMappers(this IServiceCollection services)
		{
			services.AddTransient<IArticleMapper, ArticleMapper>();
			services.AddTransient<ICategoryMapper, CategoryMapper>();
			services.AddTransient<IArticleCommentMapper, ArticleCommentMapper>();
			services.AddTransient<INewsLetterMapper, NewsLetterMapper>();
            services.AddTransient<IAboutMapper, AboutMapper>();
			services.AddTransient<IContactMapper, ContactMapper>();
		}
	}
}
