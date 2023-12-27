using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BmesRestApi.Messages.Requests.Category;
using BmesRestApi.Messages.Response.Category;
using BmesRestApi.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BmesRestApi.Controllers
{
    [Route("api/[controller]")]

    [ApiController]


    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;


        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        //GET: api/category/id
        [HttpGet("{id}")]
        public ActionResult<GetCategoryResponse> GetCategory(long id)
        {
            var getCategoryRequest = new GetCategoryRequest
            {
                Id = id
            };

            var getCategoryResponse = _categoryService.GetCategory(getCategoryRequest);

            return getCategoryResponse;

        }



        //GET: api/category
        [HttpGet]
        public ActionResult<FetchCategoryResponse> GetCategories()
        {
            var fetchCategoryRequest = new FetchCategoryRequest { };
            var fetchCategoriesResponse = _categoryService.GetCategorys(fetchCategoryRequest);
            return fetchCategoriesResponse;
        }


        //POST: api/category
        [HttpPost]
        public ActionResult<CreateCategoryResponse> PostCategory(CreateCategoryRequest createCategoryRequest)
        {
            var createCategoryResponse = _categoryService.SaveCategory(createCategoryRequest);

            return createCategoryResponse;
        }




        //UPDATE: api/category/id
        public ActionResult<UpdateCategoryResponse> PutCategory(UpdateCategoryRequest updateCategoryRequest)
        {

            var updateCategoryResponse = _categoryService.EditCategory(updateCategoryRequest);

            return updateCategoryResponse;
        }


        //DELETE: api/category/id
        [HttpDelete("{id}")]
        public ActionResult<DeleteCategoryResponse> DeleteCategory(long id)
        {
            var deleteCategoryRequest = new DeleteCategoryRequest
            {
                Id = id
            };
            var deleteCategoryResponse = _categoryService.DeleteCategory(deleteCategoryRequest);
            return deleteCategoryResponse;
        }

    }
}

