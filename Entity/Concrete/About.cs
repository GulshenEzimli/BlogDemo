using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
	public class About : IEntity
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
