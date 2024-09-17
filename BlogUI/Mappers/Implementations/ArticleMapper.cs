using BlogUI.Mappers.Interfaces;
using BlogUI.Models.Article;
using Entity.Concrete;

namespace BlogUI.Mappers.Implementations
{
	public class ArticleMapper : IArticleMapper
	{
		public Article Map(ArticleModel model)
		{
			Article article = new Article();
			article.Id = model.Id;
            article.UniqueId = model.UniqueId;
			article.Title = model.Title;
			article.Content = model.Content;
			article.ThumbnailImage = model.ThumbnailImage;
			article.Image = model.Image;
			article.CreatedDate = model.CreatedDate;
			article.UpdatedDate = model.UpdatedDate;
			article.IsDeleted = model.IsDeleted;
			article.CategoryId = model.CategoryId;
			article.Category = new Category()
			{
				Id = model.CategoryId,
				Name = model.CategoryName
			};
			article.WriterId = model.WriterId;
			article.Writer = new Writer
			{
				Id = model.WriterId
			};

			return article;
		}

		public ArticleModel Map(Article entity)
		{
			ArticleModel model = new ArticleModel();

			model.Id = entity.Id;
            model.UniqueId = entity.UniqueId;
			model.Title = entity.Title;
			model.Content = entity.Content;
			model.ThumbnailImage = entity.ThumbnailImage;
			model.Image = entity.Image;
			model.CreatedDate = entity.CreatedDate;
			model.UpdatedDate = entity.UpdatedDate;
			model.IsDeleted = entity.IsDeleted;
			model.CategoryId = entity.CategoryId;
			model.CategoryName = entity.Category.Name;
			model.WriterId = entity.WriterId;
			return model;
		}
	}
}
