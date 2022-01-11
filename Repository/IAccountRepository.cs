using EVloga.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EVloga.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> CreatUserAsync(UserPass user);

        Task<SignInResult> PasswordSignInAsync(User loginUserModel);

        Task SingOutAsync();

    }
}
