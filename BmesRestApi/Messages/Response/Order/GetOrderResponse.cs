using System;
using BmesRestApi.Messages.DataTransferObjects.Order;

namespace BmesRestApi.Messages.Response.Order
{
	public class GetOrderResponse : ResponseBase
	{
        public OrderDto Order { get; set; }
    }
}

