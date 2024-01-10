using System;
using BmesRestApi.Messages.DataTransferObjects.Cart;

namespace BmesRestApi.Messages.Requests.Cart
{


    public class AddItemToCartRequest
	{
        public long CartId { get; set; }
        public CartItemDto CartItem { get; set; }
        public long ProductId { get; set; }
    }
}

