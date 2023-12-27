using System;
using BmesRestApi.Messages;
using BmesRestApi.Messages.Requests.Product;
using BmesRestApi.Messages.Response.Product;
using BmesRestApi.Repositories;

namespace BmesRestApi.Services.Implementations
{
	public class ProductService :IProductService
	{
        private readonly IProductRepository _productRepository;
        private readonly ICatalogueService _catalogueService;
		private MessageMapper _messageMapper;

        public ProductService(IProductRepository productRepository, ICatalogueService catalogueService)
		{
			_productRepository = productRepository;
			_catalogueService = catalogueService;
			_messageMapper = new MessageMapper();
		}


        
        public CreateProductResponse SaveProduct(CreateProductRequest createProductRequest)
		{
			if(createProductRequest != null && createProductRequest.Product != null)
			{
                var product = _messageMapper.MapToProduct(createProductRequest.Product);
                _productRepository.SaveProduct(product);

                var productDto = _messageMapper.MapToProductDto(product);

                var createProductResponse = new CreateProductResponse
                {
                    Product = productDto
                };

                return createProductResponse;
            }

			throw new Exception("There is an Issue with the Request body object");
		}



        public UpdateProductResponse EditProduct(UpdateProductRequest updateProductRequest)
        {
            UpdateProductResponse? updateProductResponse = null;

            if (updateProductRequest.Product != null && updateProductRequest.Id == updateProductRequest.Product.Id)
            {
                var product = _messageMapper.MapToProduct(updateProductRequest.Product);
                _productRepository.UpdateProduct(product);
                var productDto = _messageMapper.MapToProductDto(product);

                updateProductResponse = new UpdateProductResponse
                {
                    
                };

                return updateProductResponse;
            }


            throw new Exception("Update Product Request is Null");

        }




        public GetProductResponse GetProduct(GetProductRequest getProductRequest)
        {
            GetProductResponse? getProductResponse = null;

            if (getProductRequest != null && getProductRequest.Id > 0)
            {
                var product = _productRepository.FindProductById(getProductRequest.Id);
                var productDto = _messageMapper.MapToProductDto(product);

                getProductResponse = new GetProductResponse
                {
                    Product = productDto
                };

                return getProductResponse;
            }

            throw new Exception("Your Get Product Request object is a Null Value:");

        }




        public FetchProductResponse GetProducts(FetchProductRequest fetchProductRequest)
        {
            if(fetchProductRequest != null)
            {
                var fetchProductResponse = _catalogueService.FetchProducts(fetchProductRequest);
                return fetchProductResponse;
            }
            throw new Exception("FetchPeroduct Request Object is wrong");
        }





        public DeleteProductResponse DeleteProduct(DeleteProductRequest deleteProductRequest)
        {
            var product = _productRepository.FindProductById(deleteProductRequest.Id);
            _productRepository.DeleteProduct(product);
            var productDto = _messageMapper.MapToProductDto(product);

            return new DeleteProductResponse
            {
                Product = productDto
            };
        }
    }
}

