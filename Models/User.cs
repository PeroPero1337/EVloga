using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EVloga.Models
{
    public class User
    {
        public string email { get; set; }
        public string password { get; set; }
    }
}
