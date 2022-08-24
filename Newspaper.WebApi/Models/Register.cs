using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Newspaper.WebApi.Models
{
    public class Register
    {   
        [Required]
        [DataType(DataType.EmailAddress)]
        public string UserMail { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string UserPassword { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("UserPassword")]
        public string ReUserPassword { get; set; }
        public string UserName { get; set; }
    }
}
