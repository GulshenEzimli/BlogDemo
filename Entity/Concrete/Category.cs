using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
	public class Category : IEntity
	{
		public int Id { get; set; }
        public Guid UniqueId { get; set; } = Guid.NewGuid();    
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public List<Article> Articles { get; set; }
    }
}
