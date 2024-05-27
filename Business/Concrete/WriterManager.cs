using Business.Abstract;
using Core.Business.Concrete;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
	public class WriterManager : EntityManager<Writer>, IWriterService
	{
        public WriterManager(IWriterRepository writerRepository) : base(writerRepository)
        {
        }
    }
}
