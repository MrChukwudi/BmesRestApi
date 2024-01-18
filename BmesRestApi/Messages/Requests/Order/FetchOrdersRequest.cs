using System;
namespace BmesRestApi.Messages.Requests.Order
{
	public class FetchOrdersRequest
	{
        public int PageNumber { get; set; }
        public int OrdersPerPage { get; set; }
    }
}

