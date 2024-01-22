using System;
namespace BmesRestApi.Messages.Requests.User
{
	public class RegisterRequest
	{
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<string> Roles { get; set; }
    }
}

