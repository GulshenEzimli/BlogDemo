using BlogUI.Models.Interfaces;

namespace BlogUI.Models.About
{
    public class AboutModel : IControlModel
    {
        public int Id { get; set; }
        public string Details { get; set; }
        public string DetailsTwo { get; set; }
        public string Image { get; set; }
        public string ImageTwo { get; set; }
        public string MapLocation { get; set; }
        public bool IsDeleted { get; set; }
    }
}
