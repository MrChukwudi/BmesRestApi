using System;
using BmesRestApi.Messages.DataTransferObjects.Cart;

namespace BmesRestApi.Messages.Response.Cart
{
	public class FetchCartResponse : ResponseBase
	{
        public CartDto Cart { get; set; }
    }
}

