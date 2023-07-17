using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pos_System.API.Constants;
using Pos_System.API.Enums;
using Pos_System.API.Payload.Request.Brands;
using Pos_System.API.Payload.Response.Brands;
using Pos_System.API.Services.Interfaces;
using Pos_System.API.Utils;
using Pos_System.Domain.Models;
using Pos_System.Domain.Paginate;
using Pos_System.Repository.Interfaces;

namespace Pos_System.API.Services.Implements;

public class BrandService : BaseService<BrandService>, IBrandService
{
    public BrandService(IUnitOfWork<PosSystemContext> unitOfWork, ILogger<BrandService> logger, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(unitOfWork, logger, mapper, httpContextAccessor)
    {
    }

    public async Task<CreateNewBrandResponse> CreateNewBrand(CreateNewBrandRequest newBrandRequest)
    {
        _logger.LogInformation($"Create new brand with {newBrandRequest.Name}");
        Brand newBrand = _mapper.Map<Brand>(newBrandRequest);
        newBrand.Status = BrandStatus.Active.GetDescriptionFromEnum();
        newBrand.Id = Guid.NewGuid();
        await _unitOfWork.GetRepository<Brand>().InsertAsync(newBrand);
        bool isSuccessful = await _unitOfWork.CommitAsync() > 0;
        CreateNewBrandResponse createNewBrandResponse = null;
        if (isSuccessful)
        {
            createNewBrandResponse = _mapper.Map<CreateNewBrandResponse>(newBrand);
        }

        return createNewBrandResponse;
    }

    public async Task<IPaginate<GetBrandResponse>> GetBrands(string? searchBrandName, int page, int size)
    {
	    searchBrandName = searchBrandName?.Trim().ToLower();
	    IPaginate<GetBrandResponse> brands = await _unitOfWork.GetRepository<Brand>().GetPagingListAsync(
		    selector: x => new GetBrandResponse(x.Id, x.Name, x.Email, x.Address, x.Phone, x.PicUrl, EnumUtil.ParseEnum<BrandStatus>(x.Status), x.Stores.Count),
            predicate: string.IsNullOrEmpty(searchBrandName) ? x => true : x => x.Name.ToLower().Contains(searchBrandName),
            include: x => x.Include(x => x.Stores),
            page: page,
            size: size);
	    return brands;
    }

    public async Task<GetBrandResponse> GetBrandById(Guid brandId)
    {
	    if (brandId == Guid.Empty) throw new BadHttpRequestException(MessageConstant.Brand.EmptyBrandIdMessage);
	    GetBrandResponse brandResponse = await _unitOfWork.GetRepository<Brand>().SingleOrDefaultAsync(
		    selector: x => new GetBrandResponse(x.Id, x.Name, x.Email, x.Address, x.Phone, x.PicUrl, EnumUtil.ParseEnum<BrandStatus>(x.Status), x.Stores.Count),
            predicate: x => x.Id.Equals(brandId),
            include: x => x.Include(x => x.Stores)
		    );
        return brandResponse;
    }

    public async Task<bool> UpdateBrandInformation(Guid brandId, UpdateBrandRequest updateBrandRequest)
    {
	    if (brandId == Guid.Empty) throw new BadHttpRequestException(MessageConstant.Brand.EmptyBrandIdMessage);
	    Brand brand = await _unitOfWork.GetRepository<Brand>()
		    .SingleOrDefaultAsync(predicate: x => x.Id.Equals(brandId));
	    if (brand == null) throw new BadHttpRequestException(MessageConstant.Brand.BrandNotFoundMessage);
        _logger.LogInformation($"Start update brand {brandId}");
        updateBrandRequest.TrimString();
        brand.Name = string.IsNullOrEmpty(updateBrandRequest.Name) ? brand.Name : updateBrandRequest.Name;
        brand.Email = string.IsNullOrEmpty(updateBrandRequest.Email) ? brand.Email : updateBrandRequest.Email;
        brand.Address = string.IsNullOrEmpty(updateBrandRequest.Address) ? brand.Address : updateBrandRequest.Address;
		brand.Phone = string.IsNullOrEmpty(updateBrandRequest.Phone) ? brand.Phone : updateBrandRequest.Phone;
        brand.PicUrl = string.IsNullOrEmpty(updateBrandRequest.PicUrl) ? brand.PicUrl : updateBrandRequest.PicUrl;
        _unitOfWork.GetRepository<Brand>().UpdateAsync(brand);
        bool isSuccessful = await _unitOfWork.CommitAsync() > 0;
        return isSuccessful;
    }
}