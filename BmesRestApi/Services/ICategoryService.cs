using BmesRestApi.Messages.Requests.Category;
using BmesRestApi.Messages.Response.Category;

namespace BmesRestApi.Services
{
    public interface ICategoryService
    {
        CreateCategoryResponse SaveCategory(CreateCategoryRequest createCategoryRequest);
        UpdateCategoryResponse EditCategory(UpdateCategoryRequest updateCategoryRequest);
        GetCategoryResponse GetCategory(GetCategoryRequest getCategoryRequest);
        FetchCategoryResponse GetCategorys(FetchCategoryRequest fetchCategoryRequest);
        DeleteCategoryResponse DeleteCategory(DeleteCategoryRequest deleteCategoryRequest);
    }
}