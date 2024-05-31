using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
	public class Comment : IEntity
	{
		public int Id { get; set; }
        public int UserId{ get; set; }
        public string Title { get; set; }
		public string Content { get; set; }
		public DateTime CreatedDate { get; set; }
		public bool IsDeleted { get; set; }
        public int ArticleId { get; set; }
        public Article Article { get; set; }
        public User User { get; set; }
    }
}
