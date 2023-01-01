using AutoMapper;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.BrandDtos;
using EntityLayer.Utilities.Results.Abstract;
using EntityLayer.Utilities.Results.ComplexTypes;
using EntityLayer.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BrandManager : ManagerBase, IBrandService
    {
        public BrandManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IResult> Add(BrandAddDto brandAddDto)
        {
            var brand = Mapper.Map<Brand>(brandAddDto);
            await UnitOfWork.Brand.AddAsync(brand);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla eklenmiştir.");
        }

        public async Task<IResult> DeleteById(int brandId)
        {
            var result = await UnitOfWork.Brand.AnyAsync(a => a.Id == brandId);
            if (result)
            {
                var brand = await UnitOfWork.Brand.GetAsync(a => a.Id == brandId);
                brand.IsActive = false;
                brand.IsDeleted = true;
                await UnitOfWork.Brand.UpdateAsync(brand);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir marka bulunamadı.");
        }

        public async Task<IDataResult<BrandListDto>> GetAll()
        {
            var brand = await UnitOfWork.Brand.GetAllAsync(x => x.IsActive == true && x.IsDeleted == false, x => x.Product);
            if (brand != null)
            {
                return new DataResult<BrandListDto>(ResultStatus.Success, new BrandListDto
                {
                    Brands = brand,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<BrandListDto>(ResultStatus.Error, "Böyle bir marka bulunamadı.", null);
        }

        public async Task<IDataResult<BrandDto>> GetById(int brandId)
        {
            var brand = await UnitOfWork.Brand.GetAsync(x => x.Id == brandId, x => x.Product);
            if (brand != null)
            {
                return new DataResult<BrandDto>(ResultStatus.Success, new BrandDto
                {
                    Brand = brand,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<BrandDto>(ResultStatus.Error, "Böyle bir marka bulunamadı.", null);
        }

        public async Task<IResult> Update(BrandUpdateDto brandUpdateDto)
        {
            var brand = Mapper.Map<Brand>(brandUpdateDto);
            await UnitOfWork.Brand.UpdateAsync(brand);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla güncellenmiştir.");
        }
    }
}
