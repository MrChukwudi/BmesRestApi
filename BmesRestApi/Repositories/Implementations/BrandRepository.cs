using System;
using BmesRestApi.Database;
using BmesRestApi.Models.Product;


namespace BmesRestApi.Repositories.Implementations
{
	public class BrandRepository : IBrandRepository
	{


        //Initialize the DbContext for accessing the Database:
        public BmesDbContext _context;




        public BrandRepository(BmesDbContext context)
        {
            _context = context;
        }


        //Get Single Brand
        public Brand FindBrandById(long id)
        {
            var brand = _context.Brands.Find(id);
            if (brand != null)
            {
                return brand;
            }
            throw new Exception($"Failed to get Brand with Id {id}");

        }


        //Get All Brands
        public IEnumerable<Brand> GetAllBrands()
        {
            IEnumerable<Brand> brands = _context.Brands;
            if (brands != null) //This might be a redundant check:
            {
                return brands;
            }
            throw new Exception($"Failed to get Brand with Id");
        }


        //Save a Brand Record to the DB:
        public void SaveBrand(Brand brand)
        {
            _context.Brands.Add(brand);
            _context.SaveChanges();
        }



        //Update a Brand Record:
        public void UpdateBrand(Brand brand)
        {
            _context.Brands.Update(brand);
            _context.SaveChanges();
        }



        //Delete a Brand Record:
        public void DeleteBrand(Brand brand)
        {
            _context.Brands.Remove(brand);
            _context.SaveChanges();
        }


    }
}

