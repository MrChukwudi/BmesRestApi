using System.Collections.Generic;
using System.Net.Mail;
using BmesRestApi.Messages.DataTransferObjects.Address;
using BmesRestApi.Messages.DataTransferObjects.Cart;
using BmesRestApi.Messages.DataTransferObjects.Customer;
using BmesRestApi.Messages.DataTransferObjects.Order;
using BmesRestApi.Messages.DataTransferObjects.Product;
using BmesRestApi.Messages.DataTransferObjects.Shared;
using BmesRestApi.Models.Address;
using BmesRestApi.Models.Cart;
using BmesRestApi.Models.Customer;
using BmesRestApi.Models.Order;
using BmesRestApi.Models.Product;
using BmesRestApi.Models.Shared;

namespace BmesRestApi.Messages
{

    public class MessageMapper
	{
        
		public Brand MapToBrand(BrandDto brandDto)
		{


            var brand = new Brand();

            if (brandDto != null)
			{
                brand.Id = brandDto.Id;
				brand.Name = brandDto.Name;
				brand.Slug = brandDto.Slug;
				brand.Description = brandDto.Description;
				brand.MetaDescription = brandDto.MetaDescription;
				brand.MetaKeywords = brandDto.MetaKeywords;
				brand.BrandStatus = (BrandStatus)brandDto.BrandStatus;
				brand.ModifiedDate = brandDto.ModifiedDate;
				brand.IsDeleted = brandDto.IsDeleted;
                return brand;
            };

			throw new Exception("brandDto is null");
			
		}





		public BrandDto MapToBrandDto(Brand brand)
		{
			var brandDto = new BrandDto();

			if(brand != null)
			{

				brandDto.Id = brand.Id;
				brandDto.Name = brand.Name;
				brandDto.Slug = brand.Slug;
				brandDto.Description = brand.MetaDescription;
				brandDto.MetaKeywords = brand.MetaKeywords;
                brandDto.BrandStatus = (int)brand.BrandStatus;
                brandDto.ModifiedDate = brand.ModifiedDate;
                brandDto.IsDeleted = brand.IsDeleted;
            }

            return brandDto;

        }





		public Category MapToCategory(CategoryDto categoryDto)
		{
			var category = new Category
			{
				Id = categoryDto.Id,
				Name = categoryDto.Name,
				Slug = categoryDto.Slug,
				Description = categoryDto.Description,
				MetaDescription = categoryDto.MetaDescription,
				MetaKeywords = categoryDto.MetaKeywords,
				CategoryStatus = (CategoryStatus)categoryDto.CategoryStatus,
				ModifiedDate = categoryDto.ModifiedDate,
				IsDeleted = categoryDto.IsDeleted

			};

			return category;
		}



		public CategoryDto MapToCategoryDto(Category category)
		{
			var categoryDto = new CategoryDto();

			if(category != null)
			{
				categoryDto.Id = category.Id;
				categoryDto.Name = category.Name;
				categoryDto.Description = category.Description;
				categoryDto.MetaDescription = category.MetaDescription;
				categoryDto.MetaKeywords = category.MetaKeywords;
				categoryDto.CategoryStatus = (int)category.CategoryStatus;
				categoryDto.ModifiedDate = category.ModifiedDate;
				categoryDto.IsDeleted = category.IsDeleted;
			 }

			return categoryDto;
		}





		public Product MapToProduct(ProductDto productDto)
		{
			var product = new Product();
			if(productDto != null)
			{
				product.Id = productDto.Id;
				product.Name = productDto.Name;
				product.Slug = productDto.Slug;
				product.Description = productDto.Description;
				product.MetaDescription = productDto.MetaDescription;
				product.MetaKeywords = productDto.MetaKeywords;
				product.SKU = productDto.SKU;
				product.Model = productDto.Model;
				product.ImageUrl = productDto.ImageUrl;
				product.Price = productDto.Price;
				product.SalePrice = productDto.SalePrice;
				product.OldPrice = productDto.OldPrice;
				product.QuantityInStock = productDto.QuantityInStock;
				product.ProductStatus = (ProductStatus)productDto.ProductStatus;
				product.IsBestSeller = productDto.IsBestSeller;
				product.IsFeatured = productDto.IsFeatured;
				product.CategoryId = productDto.CategoryId;
				product.BrandId = productDto.BrandId;
				product.CreateDate = productDto.CreateDate;
				product.ModifiedDate = productDto.ModifiedDate;

            }

			return product;
		}




        public ProductDto MapToProductDto(Product product)
        {
            var productDto = new ProductDto();
            if (product != null)
            {
                productDto.Id = product.Id;
                productDto.Name = product.Name;
                productDto.Slug = product.Slug;
                productDto.Description = product.Description;
                productDto.MetaDescription = product.MetaDescription;
                productDto.MetaKeywords = product.MetaKeywords;
                productDto.SKU = product.SKU;
                productDto.Model = product.Model;
                productDto.ImageUrl = product.ImageUrl;
                productDto.Price = product.Price;
                productDto.SalePrice = product.SalePrice;
                productDto.OldPrice = product.OldPrice;
                productDto.QuantityInStock = product.QuantityInStock;
                productDto.ProductStatus = (int)product.ProductStatus;
                productDto.IsBestSeller = product.IsBestSeller;
                productDto.IsFeatured = product.IsFeatured;
                productDto.CategoryId = product.CategoryId;
                productDto.BrandId = product.BrandId;
                productDto.CreateDate = product.CreateDate;
                productDto.ModifiedDate = product.ModifiedDate;

            }

            return productDto;
        }


        public CartDto MapToCartDto(Cart cart)
        {
            var cartDto = new CartDto();
            if (cart != null)
            {
                cartDto.Id = cart.Id;
                cartDto.UniqueCartId = cart.UniqueCartId;
                cartDto.CartStatus = (int)cart.CartStatus;
                cartDto.CreateDate = cart.CreateDate;
                cartDto.ModifiedDate = cart.ModifiedDate;
                cartDto.IsDeleted = cart.IsDeleted;
            }
            return cartDto;
        }

        public Cart MapToCart(CartDto cartDto)
        {
            var cart = new Cart();

            if (cartDto != null)
            {
                cart.Id = cartDto.Id;
                cart.UniqueCartId = cartDto.UniqueCartId;
                cart.CartStatus = (CartStatus)cartDto.CartStatus;
                cart.CreateDate = cartDto.CreateDate;
                cart.ModifiedDate = cartDto.ModifiedDate;
                cart.IsDeleted = cartDto.IsDeleted;
            };

            return cart;
        }

        public CartItemDto MapToCartItemDto(CartItem cartItem)
        {
            CartItemDto cartItemDto = null;

            if (cartItem.Product != null)
            {
                var productDto = MapToProductDto(cartItem.Product);

                cartItemDto = new CartItemDto
                {
                    Id = cartItem.Id,
                    CartId = cartItem.CartId,
                    Product = productDto,
                    Quantity = cartItem.Quantity
                };
            }

            return cartItemDto;
        }

        public CartItem MapToCartItem(CartItemDto cartItemDto)
        {
            return new CartItem
            {
                CartId = cartItemDto.CartId,
                ProductId = cartItemDto.Product.Id,
                Quantity = cartItemDto.Quantity
            };
        }




        //Mapping Address to AddressDto:
        public AddressDto MapToAddressDto(Address address)
        {
            var addressDto = new AddressDto();

            if(address != null)
            {
                addressDto.Id = address.Id;
                addressDto.Name = address.Name;
                addressDto.AddressLine1 = address.AddressLine1;
                addressDto.AddressLine2 = address.AddressLine2;
                addressDto.City = address.City;
                addressDto.Country = address.Country;
                addressDto.State = address.State;
                addressDto.ZipCode = address.ZipCode;
                addressDto.CreateDate = address.CreateDate;
                addressDto.ModifiedDate = address.ModifiedDate;
                addressDto.IsDeleted = address.IsDeleted;
            }

            return addressDto;
        }

        //Maapping AddressDto to Address:
        public Address MapToAddress(AddressDto addressDto)
        {
            var address = new Address();

            if(addressDto != null)
            {
                address.Id = addressDto.Id;
                address.Name = addressDto.Name;
                address.AddressLine1 = addressDto.AddressLine1;
                address.AddressLine2 = addressDto.AddressLine2;
                address.City = addressDto.City;
                address.Country = addressDto.Country;
                address.State = addressDto.State;
                address.ZipCode = addressDto.ZipCode;
                address.CreateDate = addressDto.CreateDate;
                address.ModifiedDate = addressDto.ModifiedDate;
                address.IsDeleted = addressDto.IsDeleted;
            }

            return address;
        }





        //Mapping to Customer:
        public Customer MapToCustomer(CustomerDto customerDto)
        {
            var person = new Person();
            if(customerDto != null)
            {
                person.Id = customerDto.Id;
                person.FirstName = customerDto.FirstName;
                person.MiddleName = customerDto.MiddleName;
                person.LastName = customerDto.LastName;
                person.EmailAddress = customerDto.EmailAddress;
                person.PhoneNumber = customerDto.PhoneNumber;
                person.Gender = (Gender)customerDto.Gender;
                person.DateOfBirth = customerDto.DateOfBirth;
                person.CreateDate = customerDto.CreateDate;
                person.ModifiedDate = customerDto.ModifiedDate;
                person.IsDeleted = customerDto.IsDeleted;
            }

            return new Customer
            {
                Id = customerDto.Id,
                Person = person
            };
        }


        public CustomerDto MapToCustomerDto(Customer customer)
        {
            var customerDto = new CustomerDto();
            if(customer != null)
            {
                customerDto.Id = customer.Id;
                customerDto.FirstName = customer.Person.FirstName;
                customerDto.MiddleName = customer.Person.MiddleName;
                customerDto.LastName = customer.Person.LastName;
                customerDto.EmailAddress = customer.Person.EmailAddress;
                customerDto.PhoneNumber = customer.Person.PhoneNumber;
                customerDto.Gender = (int)customer.Person.Gender;
                customerDto.DateOfBirth = customer.Person.DateOfBirth;
                customerDto.CreateDate = customer.CreateDate;
                customerDto.ModifiedDate = customer.ModifiedDate;
                customerDto.IsDeleted = customer.IsDeleted;
            }

            return customerDto;
        }



        public Person MapToPerson(PersonDto personDto)
        {
            var person = new Person();
            if(personDto != null)
            {
                person.Id = personDto.Id;
                person.FirstName = personDto.FirstName;
                person.MiddleName = personDto.MiddleName;
                person.LastName = personDto.LastName;
                person.EmailAddress = personDto.EmailAddress;
                person.PhoneNumber = personDto.PhoneNumber;
                person.Gender = (Gender)personDto.Gender;
                person.DateOfBirth = personDto.DateOfBirth;
                person.CreateDate = personDto.CreateDate;
                person.ModifiedDate = personDto.ModifiedDate;
                person.IsDeleted = personDto.IsDeleted;
            }

            return person;
        }



        public PersonDto MapToPersonDto(Person person)
        {
            var personDto = new PersonDto
            {
                Id = person.Id,
                FirstName = person.FirstName,
                MiddleName = person.MiddleName,
                LastName = person.LastName,
                EmailAddress = person.EmailAddress,
                PhoneNumber = person.PhoneNumber,
                Gender = (int)person.Gender,
                DateOfBirth = person.DateOfBirth,
                CreateDate = person.CreateDate,
                ModifiedDate = person.ModifiedDate,
                IsDeleted = person.IsDeleted
            };

            return personDto;
        }



        public OrderDto MapToOrderDto(Order order)
        {
            var orderDto = new OrderDto
            {
                Id = order.Id,
                OrderTotal = order.OrderTotal,
                OrderItemTotal = order.OrderTotal,
                ShippingCharge = order.ShippingCharge,
                CustomerId = order.CustomerId,
                OrderStatus = (int)order.OrderStatus,
                CreateDate = order.CreateDate,
                ModifiedDate = order.ModifiedDate,
                IsDeleted = order.IsDeleted
            };

            return orderDto;
        }

        public Order MapToOrder(OrderDto orderDto)
        {
            return new Order
            {
                Id = orderDto.Id,
                OrderTotal = orderDto.OrderTotal,
                OrderItemTotal = orderDto.OrderTotal,
                ShippingCharge = orderDto.ShippingCharge,
                CustomerId = orderDto.CustomerId,
                OrderStatus = (OrderStatus)orderDto.OrderStatus,
                CreateDate = orderDto.CreateDate,
                ModifiedDate = orderDto.ModifiedDate,
                IsDeleted = orderDto.IsDeleted
            };
        }

        public OrderItemDto MapToOrderItemDto(OrderItem orderItem)
        {
            OrderItemDto orderItemDto = null;

            if (orderItem?.Product != null)
            {
                var productDto = MapToProductDto(orderItem.Product);

                orderItemDto = new OrderItemDto
                {
                    Id = orderItem.Id,
                    OrderId = orderItem.OrderId,
                    Product = productDto,
                    Quantity = orderItem.Quantity
                };
            }

            return orderItemDto;
        }

        public OrderItem MapToOrderItem(OrderItemDto orderItemDto)
        {
            return new OrderItem
            {
                OrderId = orderItemDto.OrderId,
                ProductId = orderItemDto.Product.Id,
                Quantity = orderItemDto.Quantity
            };
        }




        /*
		 ADDING MAPPINGS FOR LISTS
		 */

        //Mapping a ;ist of Returned Products to Product Dtos for sharing with a client:
        public List<BrandDto> MapToBrandDtos(IEnumerable<Brand> brands)
        {
            var brandDtos = new List<BrandDto>();
            foreach (var brand in brands)
            {
                var brandDto = MapToBrandDto(brand);
                brandDtos.Add(brandDto);
            }
            return brandDtos;
        }



        //Mapping a list of Returned Categories to Category Dtos for sharing with a client:

        public List<CategoryDto> MapToCategoryDtos(IEnumerable<Category> categories)
		{
			var categoryDtos = new List<CategoryDto>();

			foreach(var category in categories)
			{
				var categoryDto = MapToCategoryDto(category);
				categoryDtos.Add(categoryDto);
			}

			return categoryDtos;
		}




        //Mapping a list of Returned Brands to Brand Dtos for sharing with a client:

        public List<ProductDto> MapToProductDtos(IEnumerable<Product> products)
		{
			var productDtos = new List<ProductDto>();
			foreach(var product in products)
			{
				var productDto = MapToProductDto(product);
				productDtos.Add(productDto);
			}

			return productDtos;
		}

        //Mapping a list of Returned CartItems to CartDtos for sharing with a client:
        public List<CartItemDto> MapToCartItemDtos(IEnumerable<CartItem> cartItems)
        {
            var cartItemDtos = new List<CartItemDto>();
            foreach (var cartItem in cartItems)
            {
                var cartItemDto = MapToCartItemDto(cartItem);
                cartItemDtos.Add(cartItemDto);
            }
            return cartItemDtos;
        }


        //Mapping a List of Addresses from DB to a List of AddressDtos for response:
        public IEnumerable<AddressDto> MapToAddressDtos(List<Address> addresses)
        {
            var addressDtos = new List<AddressDto>();
            foreach (var address in addresses)
            {
                var addressDto = MapToAddressDto(address);
                addressDtos.Add(addressDto);
            }

            return addressDtos;
        }




    }
}

