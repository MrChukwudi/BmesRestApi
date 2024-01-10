using System;
namespace BmesRestApi.Messages.Response.Cart
{
	public class RemoveItemFromCartResponse : ResponseBase
	{
        public long CartItemId { get; set; }
    }
}

