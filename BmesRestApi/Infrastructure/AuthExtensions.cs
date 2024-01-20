using System;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace BmesRestApi.Infrastructure
{
	public static class AuthExtensions
	{
		public static IServiceCollection AddJwtAuth(this IServiceCollection services, IConfiguration configuration) //Here we use "this" keyword to point the service we want to attach the method AddJwtAuth to:, then our IConfiguration is the input parameter.
		{
            var settings = configuration.GetSection("AuthSettings");
            var authSettings = settings.Get<AuthSettings>();


            var key = Encoding.ASCII.GetBytes(authSettings.Key);

            services.AddAuthorization();



            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(x =>
                {
                    x.TokenValidationParameters = new TokenValidationParameters
                    {
                        IssuerSigningKey = new SymmetricSecurityKey(key),
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };
                });

            return services;
        }
	}
}

