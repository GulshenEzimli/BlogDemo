using BlogUI.Mappers.Interfaces;
using BlogUI.Models.Article;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.ViewComponents.Comments
{
    public class CommentsToArticle : ViewComponent
    {
        private readonly ICommentService _commentService;
		private readonly IArticleCommentMapper _articleCommentMapper;

		public CommentsToArticle(ICommentService commentService, IArticleCommentMapper articleCommentMapper)
		{
			_commentService = commentService;
			_articleCommentMapper = articleCommentMapper;
		}


		public IViewComponentResult Invoke(int id)
        {
			var comments = _commentService.ArticleCommentsWithUser(id);
			var articleComments = new List<ArticleComment>();

			foreach (var comment in comments)
			{
				var articleComment = _articleCommentMapper.Map(comment);
				articleComments.Add(articleComment);
			}
			return View(articleComments);
        }
    }
}
