using System;
namespace BmesRestApi.Messages.Response.User
{
	public class FindUserByEmailResponse : ResponseBase
	{
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}

