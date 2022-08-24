using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Newspaper.WebApi.Models
{
    public class Kitap
    {
        public int Id { get; set; }
        public string isim { get; set; }
        public string Yazar { get; set; }
        public string Yayinevi { get; set; }
        public int Fiyat { get; set; }
        public int Stok { get; set; }
    }
}
