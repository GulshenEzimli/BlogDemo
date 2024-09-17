using BlogUI.Models.Interfaces;

namespace BlogUI.Models.Article
{
	public class ArticleModel : IControlModel
	{
		public int Id { get; set; }
        public Guid UniqueId { get; set; }
        public string Title { get; set; }
		public string Content { get; set; }
		public string ThumbnailImage { get; set; }
		public string Image { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime UpdatedDate { get; set; }
		public bool IsDeleted { get; set; }
		public int CategoryId { get; set; }
		public string CategoryName { get; set; }
        public int WriterId { get; set; }
    }
}
