using BlogUI.Mappers.Interfaces;
using BlogUI.Models.Article;
using Entity.Concrete;

namespace BlogUI.Mappers.Implementations
{
	public class ArticleCommentMapper : IArticleCommentMapper
	{
		public Comment Map(ArticleComment model)
		{
			Comment comment = new Comment();
			comment.ArticleId = model.ArticleId;
			comment.Article = new Article
			{
				Id = model.ArticleId,
			};	
			comment.Content = model.Content;
			comment.CreatedDate = model.CreatedDate;
			comment.IsDeleted = model.IsDeleted;
			comment.Title = model.Title;
			comment.UserId = model.UserId;
			comment.User = new User()
			{
				Id = model.UserId,
			};
			return comment;
		}

		public ArticleComment Map(Comment entity)
		{
			ArticleComment articleComment = new ArticleComment();

			articleComment.Id = entity.Id;
			articleComment.ArticleId = entity.ArticleId;
			articleComment.IsDeleted = entity.IsDeleted;
			articleComment.CreatedDate = entity.CreatedDate;
			articleComment.Content = entity.Content;
			articleComment.Title = entity.Title;
			articleComment.UserId = entity.UserId;
			articleComment.UserName = entity.User.FirstName;
			articleComment.UserSurName = entity.User.LastName;

			return articleComment;
		}
	}
}
