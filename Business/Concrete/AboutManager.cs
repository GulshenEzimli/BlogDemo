using Business.Abstract;
using Core.Business.Concrete;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
	public class AboutManager : EntityManager<About>,IAboutService
	{
        public AboutManager(IAboutRepository aboutRepository) : base(aboutRepository)
        {
            
        }
    }
}
