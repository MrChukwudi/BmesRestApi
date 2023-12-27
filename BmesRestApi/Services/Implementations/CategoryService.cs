using System;
using BmesRestApi.Messages;
using BmesRestApi.Messages.Requests.Category;
using BmesRestApi.Messages.Response.Category;
using BmesRestApi.Repositories;

namespace BmesRestApi.Services.Implementations
{
	public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private MessageMapper _messageMapper;



        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            _messageMapper = new MessageMapper();

        }


        public CreateCategoryResponse SaveCategory(CreateCategoryRequest categoryRequest)
        {
            if (categoryRequest != null && categoryRequest.Category != null)
            {
                var category = _messageMapper.MapToCategory(categoryRequest.Category);


                _categoryRepository.SaveCategory(category);
                var categoryDto = _messageMapper.MapToCategoryDto(category);


                var createCategoryResponse = new CreateCategoryResponse
                {
                    Category = categoryDto
                };

                return createCategoryResponse;
            }

            throw new Exception("Bad CreateCategoryRequest Object");
        }




        public UpdateCategoryResponse EditCategory(UpdateCategoryRequest updateCategoryRequest)
        {
            UpdateCategoryResponse? updateCategoryResponse = null;

            if (updateCategoryRequest.Category != null && updateCategoryRequest.Id == updateCategoryRequest.Category.Id)
            {
                var category = _messageMapper.MapToCategory(updateCategoryRequest.Category);
                _categoryRepository.UpdateCategory(category);
                var categoryDto = _messageMapper.MapToCategoryDto(category);


                updateCategoryResponse = new UpdateCategoryResponse
                {

                };

                return updateCategoryResponse;


            }
            throw new Exception("The updateCategoryRequest Objext was null;");

        }


        public GetCategoryResponse GetCategory(GetCategoryRequest getCategoryRequest)
        {
            GetCategoryResponse? getCategoryResponse = null;

            if (getCategoryRequest != null && getCategoryRequest.Id > 0)
            {
                var category = _categoryRepository.FindCategoryById(getCategoryRequest.Id);
                var categoryDto = _messageMapper.MapToCategoryDto(category);


                getCategoryResponse = new GetCategoryResponse
                {
                    Category = categoryDto
                };

                return getCategoryResponse;
            }

            throw new Exception("GetCategoryResponse was still null");
        }



        public FetchCategoryResponse GetCategorys(FetchCategoryRequest fetchCategoryRequest)
        {
            var categorys = _categoryRepository.GetAllCategories();
            var categoryDtos = _messageMapper.MapToCategoryDtos(categorys);

            return new FetchCategoryResponse
            {
                Categories = categoryDtos
            };
        }



        public DeleteCategoryResponse DeleteCategory(DeleteCategoryRequest deleteCategoryRequest)
        {
            var category = _categoryRepository.FindCategoryById(deleteCategoryRequest.Id);
            _categoryRepository.DeleteCategory(category);
            var categoryDto = _messageMapper.MapToCategoryDto(category);




            return new DeleteCategoryResponse
            {
                Category = categoryDto
            };
        }
    }
}

