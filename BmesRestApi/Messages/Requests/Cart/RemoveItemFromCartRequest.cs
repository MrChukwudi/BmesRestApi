using System;
namespace BmesRestApi.Messages.Requests.Cart
{
	public class RemoveItemFromCartRequest
	{
        public long CartId { get; set; }
        public long CartItemId { get; set; }
    }
}

