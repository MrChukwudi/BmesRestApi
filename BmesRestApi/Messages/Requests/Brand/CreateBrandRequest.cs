using System;
using BmesRestApi.Messages.DataTransferObjects.Product;

namespace BmesRestApi.Messages.Requests.Brand
{
	public class CreateBrandRequest
	{
        //For my project's Purpose, these is the Parameter that I will need when performing a Create Brand request:

        public BrandDto? Brand { get; set; }
	}
}

