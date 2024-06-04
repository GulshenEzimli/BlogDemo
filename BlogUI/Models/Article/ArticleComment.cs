using BlogUI.Models.Interfaces;

namespace BlogUI.Models.Article
{
	public class ArticleComment : IControlModel
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public string UserName { get; set; }
		public string UserSurName { get; set; }
		public string UserFullName => $"{UserName} {UserSurName}"; 
		public string Title { get; set; }
		public string Content { get; set; }
		public DateTime CreatedDate { get; set; }
		public bool IsDeleted { get; set; }
		public int ArticleId { get; set; }
	}
}
