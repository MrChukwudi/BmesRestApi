using BmesRestApi.Messages;
using BmesRestApi.Messages.Requests.Product;
using BmesRestApi.Messages.Response.Product;
using BmesRestApi.Models.Product;
using BmesRestApi.Repositories;

namespace BmesRestApi.Services.Implementations
{
    public class CatalogueService : ICatalogueService
    {
        private IProductRepository _productRepository;
        private MessageMapper _messageMapper;



        public CatalogueService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
            _messageMapper = new MessageMapper();
        }




        public FetchProductResponse FetchProducts(FetchProductRequest fetchProductsRequest)
        {

            IEnumerable<Product> products = new List<Product>();

            int productCount = 0;

            if (fetchProductsRequest.CategorySlug == "all-categories" && fetchProductsRequest.BrandSlug == "all-brands")
            {
                productCount = _productRepository.GetAllProducts().Count();
                products = _productRepository.GetAllProducts()
                   .Where(product => product.ProductStatus == ProductStatus.Active)
                   .Skip((fetchProductsRequest.PageNumber - 1) * fetchProductsRequest.ProductsPerPage)
                   .Take(fetchProductsRequest.ProductsPerPage);
            }

            if (fetchProductsRequest.CategorySlug != "all-categories" && fetchProductsRequest.BrandSlug != "all-brands")
            {
                var filteredProducts = _productRepository.GetAllProducts()
                                                         .Where(product => product.ProductStatus == ProductStatus.Active &&
                                                                           product.Category!.Slug == fetchProductsRequest.CategorySlug &&
                                                                           product.Brand!.Slug == fetchProductsRequest.BrandSlug);
                productCount = filteredProducts.Count();
                products = filteredProducts.Skip((fetchProductsRequest.PageNumber - 1) * fetchProductsRequest.ProductsPerPage)
                                           .Take(fetchProductsRequest.ProductsPerPage);
            }

            if (fetchProductsRequest.CategorySlug != "all-categories" && fetchProductsRequest.BrandSlug == "all-brands")
            {
                var filteredProducts = _productRepository.GetAllProducts()
                                                         .Where(product => product.ProductStatus == ProductStatus.Active &&
                                                                           product.Category!.Slug == fetchProductsRequest.CategorySlug);
                productCount = filteredProducts.Count();
                products = filteredProducts.Skip((fetchProductsRequest.PageNumber - 1) * fetchProductsRequest.ProductsPerPage)
                                           .Take(fetchProductsRequest.ProductsPerPage);
            }

            if (fetchProductsRequest.CategorySlug == "all-categories" && fetchProductsRequest.BrandSlug != "all-brands")
            {
                var filteredProducts = _productRepository.GetAllProducts()
                                                         .Where(product => product.ProductStatus == ProductStatus.Active &&
                                                                           product.Brand!.Slug == fetchProductsRequest.BrandSlug);
                productCount = filteredProducts.Count();
                products = filteredProducts.Skip((fetchProductsRequest.PageNumber - 1) * fetchProductsRequest.ProductsPerPage)
                                           .Take(fetchProductsRequest.ProductsPerPage);
            }

            var totalPages = (int)Math.Ceiling((decimal)productCount / fetchProductsRequest.ProductsPerPage);

            int[] pages = Enumerable.Range(1, totalPages).ToArray();

            var productDtos = _messageMapper.MapToProductDtos(products);

            var fetchProductsResponse = new FetchProductResponse()
            {
                ProductsPerPage = fetchProductsRequest.ProductsPerPage,
                Products = productDtos,
                HasPreviousPages = (fetchProductsRequest.PageNumber > 1),
                CurrentPage = fetchProductsRequest.PageNumber,
                HasNextPages = (fetchProductsRequest.PageNumber < totalPages),
                Pages = pages
            };

            return fetchProductsResponse;
        }
    }
}