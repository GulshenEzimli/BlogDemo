namespace BlogUI.Models.Category
{
	public class CategoryCountsModel
	{
		public int Id { get; set; }
        public Guid UniqueId { get; set; }
        public string Name { get; set; }
		public int Count { get; set; }
	}
}
