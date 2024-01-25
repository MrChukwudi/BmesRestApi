using System;
using BmesRestApi.Models.Shared;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace BmesRestApi.Database
{
	public class IdentityDbSeeder
	{
        //public static async void Seed(BmesIdentityDbContext dbContext, RoleManager<IdentityRole> roleManager, UserManager<User> userManager)
        public static async Task Seed(BmesIdentityDbContext dbContext, RoleManager<IdentityRole> roleManager, UserManager<User> userManager)
        {
            // Create default Users (if there are none)
            if (!dbContext.Users.Any())
            {
                await CreateUsers(dbContext, roleManager, userManager);
                await dbContext.SaveChangesAsync();
            }

        }





        private static async Task CreateUsers(BmesIdentityDbContext dbContext, RoleManager<IdentityRole> roleManager, UserManager<User> userManager)
        {
            //Create Roles (if they doesn't exist yet)
            if (!await roleManager.RoleExistsAsync(UserRole.Administrator.ToString()))
            {
                await roleManager.CreateAsync(new IdentityRole(UserRole.Administrator.ToString()));
            }
            if (!await roleManager.RoleExistsAsync(UserRole.RegisteredUser.ToString()))
            {
                await roleManager.CreateAsync(new IdentityRole(UserRole.RegisteredUser.ToString()));
            }

            // Create the "Admin" User account
            var userAdmin = new User
            {
                SecurityStamp = Guid.NewGuid().ToString(),
                Name = "Chinedu Ogbu",
                UserName = "admins@yahoo.com",
                Email = "admins@yahoo.com"
            };
            // Insert "Admin" into the Database and assign the "Administrator" and "Registered" roles to him.
            if (await userManager.FindByNameAsync(userAdmin.UserName) == null)
            {
                await userManager.CreateAsync(userAdmin, "MyGodIsGood2*");
                await userManager.AddToRoleAsync(userAdmin, UserRole.Administrator.ToString());
                await userManager.AddToRoleAsync(userAdmin, UserRole.RegisteredUser.ToString());
                // Remove Lockout and E-Mail confirmation.
                userAdmin.EmailConfirmed = true;
                userAdmin.LockoutEnabled = false;
            }
            
        }

    }
}

