using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
	public class User :IEntity
	{
        public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string About { get; set; }
		public string Image { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime UpdatedDate { get; set; }
		public bool IsDeleted { get; set; }
	}
}
