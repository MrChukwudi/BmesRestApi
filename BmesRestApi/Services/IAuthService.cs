using System;
using BmesRestApi.Messages.Requests.User;
using BmesRestApi.Messages.Response.User;

namespace BmesRestApi.Services
{
	public interface IAuthService
	{
        Task<RegisterResponse> RegisterAsync(RegisterRequest request, CancellationToken cancellationToken = default);
        Task<LogInResponse> LogInAsync(LogInRequest request, CancellationToken cancellationToken = default);
    }
}

