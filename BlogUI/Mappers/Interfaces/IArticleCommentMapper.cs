using BlogUI.Models.Article;
using Entity.Concrete;

namespace BlogUI.Mappers.Interfaces
{
	public interface IArticleCommentMapper : IControlModelMapper<Comment,ArticleComment>
	{
	}
}
