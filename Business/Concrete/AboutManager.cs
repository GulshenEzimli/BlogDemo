using Core.DataAccess.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class AboutManager : EntityManager<About>
	{
        public AboutManager(IAboutRepository aboutRepository) : base(aboutRepository)
        {
            
        }
    }
}
