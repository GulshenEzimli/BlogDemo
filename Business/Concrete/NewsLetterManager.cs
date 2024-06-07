using Business.Abstract;
using Core.Business.Concrete;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class NewsLetterManager : EntityManager<NewsLetter>,INewsLetterService
	{
        public NewsLetterManager(INewsLetterRepository newsLetterRepository) : base(newsLetterRepository)
        {

        }
    }
}
