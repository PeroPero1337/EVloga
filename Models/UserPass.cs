using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EVloga.Models
{
    [NotMapped]
    public class UserPass : RegUser
    {
        public string Password { get; set; }
    }
}
