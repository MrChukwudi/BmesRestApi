using System;
using BmesRestApi.Messages.Requests.Order;
using BmesRestApi.Messages.Response.Order;
using BmesRestApi.Repositories;

namespace BmesRestApi.Services.Implementations
{
	public class OrderService : IOrderService
	{
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public GetOrderResponse GetOrder(GetOrderRequest getOrderRequest)
        {
            //We didn't flesh this out because it's not relevant to this Project.
            return new GetOrderResponse();
        }

        public FetchOrdersResponse GetOrders(FetchOrdersRequest fetchOrdersRequest)
        {
            //We didn't flesh this out because it's not relevant to this Project.
            return new FetchOrdersResponse();
        }
    }
}

