using AutoMapper;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.CategoryDtos;
using EntityLayer.Utilities.Results.Abstract;
using EntityLayer.Utilities.Results.ComplexTypes;
using EntityLayer.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ManagerBase, ICategoryService
    {
        public CategoryManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IResult> Add(CategoryAddDto categoryAddDto)
        {
            var category = Mapper.Map<Category>(categoryAddDto);
            await UnitOfWork.Category.AddAsync(category);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla eklenmiştir.");
        }

        public async Task<IResult> DeleteById(int categoryId)
        {
            var result = await UnitOfWork.Category.AnyAsync(a => a.Id == categoryId);
            if (result)
            {
                var category = await UnitOfWork.Category.GetAsync(a => a.Id == categoryId);
                category.IsActive = false;
                category.IsDeleted = true;
                await UnitOfWork.Category.UpdateAsync(category);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir kategori bulunamadı.");
        }

        public async Task<IDataResult<CategoryListDto>> GetAll()
        {
            var category = await UnitOfWork.Category.GetAllAsync(x => x.IsActive == true && x.IsDeleted == false, x => x.SubCategories);
            if (category != null)
            {
                return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto
                {
                    Categories = category,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CategoryListDto>(ResultStatus.Error, "Böyle bir kategori bulunamadı.", null);
        }

        public async Task<IDataResult<CategoryDto>> GetById(int categoryId)
        {
            var category = await UnitOfWork.Category.GetAsync(x => x.Id == categoryId, null);
            if (category != null)
            {
                return new DataResult<CategoryDto>(ResultStatus.Success, new CategoryDto
                {
                    Category = category,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CategoryDto>(ResultStatus.Error, "Böyle bir categori bulunamadı.", null);
        }

        public async Task<IResult> Update(CategoryUpdateDto categoryUpdateDto)
        {
            var category = Mapper.Map<Category>(categoryUpdateDto);
            await UnitOfWork.Category.UpdateAsync(category);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla güncellenmiştir.");
        }
    }
}
