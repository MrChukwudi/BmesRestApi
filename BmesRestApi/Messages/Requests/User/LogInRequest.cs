﻿using System;
namespace BmesRestApi.Messages.Requests.User
{
	public class LogInRequest
	{
        public string Email { get; set; }
        public string Password { get; set; }
    }
}

