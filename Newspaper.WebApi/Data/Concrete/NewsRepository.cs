using Newspaper.WebApi.Data.Abstract;
using Newspaper.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Newspaper.WebApi.Data.Concrete
{
    public class NewsRepository : INewsRepository
    {
        public Haber Add(Haber Haber)
        {
            using (var haberDbContext = new ApplicationDbContext())
            {
                haberDbContext.Haberler.Add(Haber);
                haberDbContext.SaveChanges();
                return Haber;

            }
        }

        public void Delete(int Id)
        {
            using (var haberDbContext = new ApplicationDbContext())
            {
                var deletedNew = haberDbContext.Haberler.Find(Id);
                haberDbContext.Haberler.Remove(deletedNew);
                haberDbContext.SaveChanges();
            }
        }

        public List<Haber> GetAll()
        {
            using (var haberDbContext = new ApplicationDbContext())
            {
                return haberDbContext.Haberler.ToList();
            }
        }

        public Haber GetById(int Id)
        {
            using (var haberDbContext = new ApplicationDbContext())
            {
                return haberDbContext.Haberler.Find(Id);

            }
        }

        public Haber Update(Haber Haber)
        {
            using (var haberDbContext = new ApplicationDbContext())
            {
                haberDbContext.Haberler.Update(Haber);
                haberDbContext.SaveChanges();
                return Haber;
            }
        }
    }
}
