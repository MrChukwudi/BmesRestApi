using System;
using BmesRestApi.Messages;
using BmesRestApi.Repositories;
using BmesRestApi.Repositories.Implementations;

namespace BmesRestApi.Services.Implementations
{
	public class CheckoutService : ICheckoutService
	{
        private readonly IOrderRepository _orderRepository;
        private MessageMapper _messageMapper;
        private ICustomerRepository _customerRepository;
        private IPersonRepository _personRepository;
        private IAddressRepository _addressRepository;
        private IOrderItemRepository _orderItemRepository;
        private ICartRepository _cartRepository;
        private ICartItemRepository _cartItemRepository;
        private ICartService _cartService;


        public CheckoutService(
            ICustomerRepository customerRepository,
            IPersonRepository personRepository,
            IAddressRepository addressRepository,
            IOrderRepository orderRepository,
            IOrderItemRepository orderItemRepository,
            ICartRepository cartRepository,
            ICartItemRepository cartItemRepository,
            ICartService cartService
            )
		{
            _orderRepository = orderRepository;
            _messageMapper = new MessageMapper();
            _customerRepository = customerRepository;
            _personRepository = personRepository;
            _addressRepository = addressRepository;
            _orderItemRepository = orderItemRepository;
            _cartRepository = cartRepository;
            _cartItemRepository = cartItemRepository;
            _cartService = cartService;
        }
	}
}

