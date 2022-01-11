using EVloga.Models;
using EVloga.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EVloga.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAccountRepository _accountRepository;

        public HomeController(ILogger<HomeController> logger, IAccountRepository accountRepository)
        {
            _logger = logger;
            _accountRepository = accountRepository;
        }

        public IActionResult Index()
        {

            //navadn user - dragica@gmail.com Dragica123!
            //socialna - soc@domain.si Admin123!
            //furs - furs@domain.si Asd123!

            if (User.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Main");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(User user)
        {

            if (ModelState.IsValid)
            {
                var result = await _accountRepository.PasswordSignInAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Main");
                }

                ModelState.AddModelError("", "Nepravilna prijava");
            }
            return View(user);
        }

        public async Task<IActionResult> Logout()
        {
            await _accountRepository.SingOutAsync();
            return RedirectToAction("Index", "Home");

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
