using Newspaper.WebApi.Business.Abstract;
using Newspaper.WebApi.Data.Abstract;
using Newspaper.WebApi.Data.Concrete;
using Newspaper.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Newspaper.WebApi.Business.Concrete
{
    public class NewsManager : INewsService
    {
        private INewsRepository _newsRepository;
        public NewsManager()
        {
            _newsRepository = new NewsRepository();
        }
        public Haber Add(Haber Haber)
        {
            return _newsRepository.Add(Haber);
        }

        public void Delete(int Id)
        {
            _newsRepository.Delete(Id);
        }

        public List<Haber> GetAll()
        {
            return _newsRepository.GetAll();
        }

        public Haber GetById(int Id)
        {

                return _newsRepository.GetById(Id);
        }

        public Haber Update(Haber Haber)
        {
            return _newsRepository.Update(Haber);
        }
    }
}
