﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EVloga.Models
{
    public class RegUser : IdentityUser
    {
        public override string Email { get; set; }
    }
}
