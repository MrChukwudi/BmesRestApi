using System;
using BmesRestApi.Messages;
using BmesRestApi.Messages.Requests.Brand;
using BmesRestApi.Messages.Response.Brand;
using BmesRestApi.Repositories;

namespace BmesRestApi.Services.Implementations
{
	public class BrandService : IBrandService
	{

		private readonly IBrandRepository _brandRepository;
		private MessageMapper _messageMapper;



		public BrandService(IBrandRepository brandRepository)
		{
			_brandRepository = brandRepository;
			_messageMapper = new MessageMapper();

        }


		public CreateBrandResponse SaveBrand(CreateBrandRequest brandRequest)
		{
			if(brandRequest != null && brandRequest.Brand != null)
			{
                var brand = _messageMapper.MapToBrand(brandRequest.Brand);


                _brandRepository.SaveBrand(brand);
                var brandDto = _messageMapper.MapToBrandDto(brand);


                var createBrandResponse = new CreateBrandResponse
                {
                    Brand = brandDto
                };

                return createBrandResponse;
            }

			throw new Exception("Bad CreateBrandRequest Object");
		}




		public UpdateBrandResponse EditBrand(UpdateBrandRequest updateBrandRequest)
		{
			UpdateBrandResponse? updateBrandResponse = null;

			if(updateBrandRequest.Brand != null && updateBrandRequest.Id == updateBrandRequest.Brand.Id)
			{
				var brand = _messageMapper.MapToBrand(updateBrandRequest.Brand);
				_brandRepository.UpdateBrand(brand);
				var brandDto = _messageMapper.MapToBrandDto(brand);


				updateBrandResponse = new UpdateBrandResponse
				{

				};

                return updateBrandResponse;


            }
			throw new Exception("The updateBrandRequest Objext was null;");
			
		}


		public GetBrandResponse GetBrand(GetBrandRequest getBrandRequest)
		{
			GetBrandResponse? getBrandResponse = null;

			if(getBrandRequest != null && getBrandRequest.Id > 0)
			{
				var brand = _brandRepository.FindBrandById(getBrandRequest.Id);
				var brandDto = _messageMapper.MapToBrandDto(brand);


                getBrandResponse = new GetBrandResponse
                {
                    Brand = brandDto
				};

                return getBrandResponse;
            }

			throw new Exception("GetBrandResponse was still null");
        }



		public FetchBrandResponse GetBrands(FetchBrandRequest fetchBrandRequest)
		{
			var brands = _brandRepository.GetAllBrands();
			var brandDtos = _messageMapper.MapToBrandDtos(brands);

			return new FetchBrandResponse
			{
				Brands = brandDtos
			};
		}



		public DeleteBrandResponse DeleteBrand(DeleteBrandRequest deleteBrandRequest)
		{
			var brand = _brandRepository.FindBrandById(deleteBrandRequest.Id);
			_brandRepository.DeleteBrand(brand);
			var brandDto = _messageMapper.MapToBrandDto(brand);




			return new DeleteBrandResponse
			{
				Brand = brandDto
			};
		}


	}
}

