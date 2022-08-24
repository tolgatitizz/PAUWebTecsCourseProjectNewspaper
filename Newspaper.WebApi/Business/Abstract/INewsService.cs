using Newspaper.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Newspaper.WebApi.Business.Abstract
{
    interface INewsService
    {
        List<Haber> GetAll();
        Haber GetById(int Id);
        Haber Add(Haber Haber);
        Haber Update(Haber Haber);
        void Delete(int Id);

    }
}
