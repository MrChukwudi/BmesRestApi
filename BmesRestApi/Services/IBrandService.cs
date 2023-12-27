using BmesRestApi.Messages.Requests.Brand;
using BmesRestApi.Messages.Response.Brand;

namespace BmesRestApi.Services
{
    public interface IBrandService
    {
        CreateBrandResponse SaveBrand(CreateBrandRequest brandRequest);
        UpdateBrandResponse EditBrand(UpdateBrandRequest updateBrandRequest);
        GetBrandResponse GetBrand(GetBrandRequest getBrandRequest);
        FetchBrandResponse GetBrands(FetchBrandRequest fetchBrandsRequest);
        DeleteBrandResponse DeleteBrand(DeleteBrandRequest deleteBrandRequest);
    }
}
