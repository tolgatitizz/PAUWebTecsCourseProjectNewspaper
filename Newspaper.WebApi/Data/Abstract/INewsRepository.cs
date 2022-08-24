using Newspaper.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Newspaper.WebApi.Data.Abstract
{
    interface INewsRepository
    {
        List<Haber> GetAll();
        Haber GetById(int Id);
        Haber Add(Haber Haber);
        Haber Update(Haber Haber);
        void Delete(int Id);

    }
}
