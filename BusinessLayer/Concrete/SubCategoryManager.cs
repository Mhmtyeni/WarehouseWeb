using AutoMapper;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.SubCategoryDtos;
using EntityLayer.Utilities.Results.Abstract;
using EntityLayer.Utilities.Results.ComplexTypes;
using EntityLayer.Utilities.Results.Concrete;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SubCategoryManager : ManagerBase, ISubCategoryService
    {
        public SubCategoryManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        public async Task<IResult> Add(SubCategoryAddDto subCategoryAddDto)
        {
            var subCategory = Mapper.Map<SubCategory>(subCategoryAddDto);
            await UnitOfWork.SubCategory.AddAsync(subCategory);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla eklenmiştir.");
        }

        public async Task<IResult> DeleteById(int subCategoryId)
        {
            var result = await UnitOfWork.SubCategory.AnyAsync(a => a.Id == subCategoryId);
            if (result)
            {
                var subCategory = await UnitOfWork.SubCategory.GetAsync(a => a.Id == subCategoryId);
                subCategory.IsActive = false;
                subCategory.IsDeleted = true;
                await UnitOfWork.SubCategory.UpdateAsync(subCategory);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir kategori bulunamadı.");
        }

        public async Task<IDataResult<SubCategoryListDto>> GetAll()
        {
            var subCategories = await UnitOfWork.SubCategory.GetAllAsync(x => x.IsActive == true && x.IsDeleted == false, x => x.Products, x => x.Category);
            if (subCategories != null)
            {
                return new DataResult<SubCategoryListDto>(ResultStatus.Success, new SubCategoryListDto
                {
                    SubCategories = subCategories,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<SubCategoryListDto>(ResultStatus.Error, "Böyle bir kategori bulunamadı.", null);
        }

        public async Task<IDataResult<SubCategoryListDto>> GetByCategoryId(int categoryId)
        {
            var subCategory = await UnitOfWork.SubCategory.GetAllAsync(x => x.CategoryId == categoryId && x.IsActive == true && x.IsDeleted == false, null);
            if (subCategory != null)
            {
                return new DataResult<SubCategoryListDto>(ResultStatus.Success, new SubCategoryListDto
                {
                    SubCategories = subCategory,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<SubCategoryListDto>(ResultStatus.Error, "Böyle bir categori bulunamadı.", null);
        }

        public async Task<IDataResult<SubCategoryDto>> GetById(int subCategoryId)
        {
            var subCategory = await UnitOfWork.SubCategory.GetAsync(x => x.Id == subCategoryId, x => x.Products, x => x.Category);
            if (subCategory != null)
            {
                return new DataResult<SubCategoryDto>(ResultStatus.Success, new SubCategoryDto
                {
                    SubCategory = subCategory,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<SubCategoryDto>(ResultStatus.Error, "Böyle bir categori bulunamadı.", null);
        }

        public async Task<IResult> Update(SubCategoryUpdateDto subCategoryUpdateDto)
        {
            var subCategory = Mapper.Map<SubCategory>(subCategoryUpdateDto);
            await UnitOfWork.SubCategory.UpdateAsync(subCategory);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla güncellenmiştir.");
        }
    }
}
