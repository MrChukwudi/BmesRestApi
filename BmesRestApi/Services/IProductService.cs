using BmesRestApi.Messages.Requests.Product;
using BmesRestApi.Messages.Response.Product;

namespace BmesRestApi.Services
{
    public interface IProductService
    {
        CreateProductResponse SaveProduct(CreateProductRequest createProductRequest);
        UpdateProductResponse EditProduct(UpdateProductRequest updateProductRequest);
        GetProductResponse GetProduct(GetProductRequest getProductRequest);
        FetchProductResponse GetProducts(FetchProductRequest fetchProductsRequest);
        DeleteProductResponse DeleteProduct(DeleteProductRequest deleteProductRequest);
    }
}
