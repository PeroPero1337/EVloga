using EVloga.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EVloga.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new EvlogaContext())
            {
                var all = db.podatki.Where(x => x.Vlagatelj == User.Identity.Name);

                return View(all.ToList());
            }
            
        }
    }
}
