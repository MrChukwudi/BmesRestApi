using System;
using BmesRestApi.Models.Shared;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BmesRestApi.Repositories.Implementations
{
	public class AuthRepository : IAuthRepository
	{
		private SignInManager<User> _signInManager;
		private readonly UserManager<User> _userManager;


		public AuthRepository(UserManager<User> userManager, SignInManager<User> signInManager)
		{
			_signInManager = signInManager;
			_userManager = userManager;
		}

        //Register a User
        public async Task<IdentityResult> RegisterAsync(User user, string password, CancellationToken cancellationToken)
        {
            var result = await _userManager.CreateAsync(user, password);

			if (result.Succeeded)
			{
				await _userManager.AddToRoleAsync(user, UserRole.RegisteredUser.ToString());
			}

			return result;
        }


        //Login a User
        public async Task<bool> LogInAsync(string email, string password, CancellationToken cancellationToken)
        {
            var result = await _signInManager.PasswordSignInAsync(
                email, password, false, false);
            return result.Succeeded;
        }

        //Find a User by Email:
        public async Task<User> FindAsync(string request, CancellationToken cancellationToken)
        {
            return await _userManager.Users.FirstOrDefaultAsync(u => u.Email == request, cancellationToken);
        }



        //Find all the roles a User Belongs to:
        public async Task<IList<string>> FindUserRolesAsync(string email, CancellationToken cancellationToken)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Email == email, cancellationToken);
            var roles = await _userManager.GetRolesAsync(user);

            return roles;
        }
    }
}

