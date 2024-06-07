using BlogUI.Models.Interfaces;

namespace BlogUI.Models.NewsLetter
{
	public class NewsLetterModel : IControlModel
    {
        public int Id { get; set; }
        public string Mail { get; set; }
        public bool IsDeleted { get; set; }
    }
}
