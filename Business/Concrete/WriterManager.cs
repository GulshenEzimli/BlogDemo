using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class WriterManager : EntityManager<Writer>
	{
        public WriterManager(IWriterRepository writerRepository) : base(writerRepository)
        {
        }
    }
}
