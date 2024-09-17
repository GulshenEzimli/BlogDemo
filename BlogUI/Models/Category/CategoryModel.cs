using BlogUI.Models.Interfaces;

namespace BlogUI.Models.Category
{
    public class CategoryModel :IControlModel
    {
        public int Id { get; set; }
        public Guid UniqueId { get; set; }
        public string Name { get; set; }
		public string Description { get; set; }
	}
}
