using EVloga.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EVloga.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<RegUser> _userManager;
        private readonly SignInManager<RegUser> _signInManager;

        public AccountRepository(UserManager<RegUser> userManager, SignInManager<RegUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task<IdentityResult> CreatUserAsync(UserPass userModel)
        {
            var user = new RegUser()
            {
                Email = userModel.Email,
                UserName = userModel.Email
            };
            var result = await _userManager.CreateAsync(user, userModel.Password);
            return result;
        }

        public async Task<SignInResult> PasswordSignInAsync(User loginUserModel)
        {
            var result = await _signInManager.PasswordSignInAsync(loginUserModel.email, loginUserModel.password, false, false);
            return result;
        }

        public async Task SingOutAsync()
        {
            await _signInManager.SignOutAsync();
        }
    }
}