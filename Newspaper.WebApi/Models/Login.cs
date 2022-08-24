using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Newspaper.WebApi.Models
{
    public class Login
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string UserMail { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string UserPassword { get; set; }
    }
}
