using System;
using BmesRestApi.Messages.DataTransferObjects.Address;
using BmesRestApi.Messages.DataTransferObjects.Cart;
using BmesRestApi.Messages.DataTransferObjects.Customer;

namespace BmesRestApi.Messages.Requests.Checkout
{
	public class CheckoutRequest
	{
        public CustomerDto Customer { get; set; }

        public AddressDto Address { get; set; }

        public CartDto Cart { get; set; }
    }
}

