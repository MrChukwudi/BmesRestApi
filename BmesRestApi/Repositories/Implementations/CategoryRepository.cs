using System;
using BmesRestApi.Database;
using BmesRestApi.Models.Product;


namespace BmesRestApi.Repositories.Implementations
{
    public class CategoryRepository : ICategoryRepository
    {
       //Initialize the DbContext for accessing the Database:
            public BmesDbContext _context;
        



        public CategoryRepository(BmesDbContext context)
        {
            _context = context;
        }


        //Get Single Category
        public Category FindCategoryById(long id)
        {
            var category = _context.Categories.Find(id);
            if (category != null)
            {
                return category;
            }
            throw new Exception($"Failed to get Category with Id {id}");

        }


        //Get All Categorys
        public IEnumerable<Category> GetAllCategories()
        {
            IEnumerable<Category> categories = _context.Categories;
            if (categories != null) //This might be a redundant check:
            {
                return categories;
            }
            throw new Exception($"Failed to get Category with Id");
        }


        //Save a Category Record to the DB:
        public void SaveCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }



        //Update a Category Record:
        public void UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
        }



        //Delete a Category Record:
        public void DeleteCategory(Category category)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }



    }
	
}

