using Microsoft.EntityFrameworkCore;
using Newspaper.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Newspaper.WebApi.Data
{
    public class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Application.db");
        }
        public DbSet<Haber> Haberler { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }
    }
}
