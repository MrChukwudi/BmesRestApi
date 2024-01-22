using System;
using BmesRestApi.Models.Shared;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BmesRestApi.Database
{
	public class BmesIdentityDbContext : IdentityDbContext<User>  //We passed in the User model because we want to make some configurations of our own, we'd have just used the "IdentityUser"
	{
		public BmesIdentityDbContext(DbContextOptions<BmesIdentityDbContext> options) : base(options)
		{
		}
	}
}

//This File allows us to create a Seperate Database to manage our User Authentication and Authorizations, and General User Security.