using System;
using BmesRestApi.Messages.DataTransferObjects.Product;

namespace BmesRestApi.Messages.Requests.Brand
{
    public class UpdateBrandRequest
    {
        //For my project's Purpose, this is the Parameter that I will need when performing a Update a Brand request:
        public int Id { get; set; }

        public BrandDto? Brand { get; set; }

    }

}