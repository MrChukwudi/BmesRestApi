using System;
using BmesRestApi.Messages.Requests.Order;
using BmesRestApi.Messages.Response.Order;

namespace BmesRestApi.Services
{

	public interface IOrderService
	{
        GetOrderResponse GetOrder(GetOrderRequest getOrderRequest);
        FetchOrdersResponse GetOrders(FetchOrdersRequest fetchOrdersRequest);
    }
}

