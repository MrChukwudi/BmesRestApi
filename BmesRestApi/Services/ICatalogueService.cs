using BmesRestApi.Messages.Requests.Product;
using BmesRestApi.Messages.Response.Product;

namespace BmesRestApi.Services
{
    public interface ICatalogueService
    {
        FetchProductResponse FetchProducts(FetchProductRequest fetchProductRequest);
    }
}