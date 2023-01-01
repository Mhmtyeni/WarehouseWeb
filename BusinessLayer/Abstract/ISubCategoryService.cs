using EntityLayer.Concrete;
using EntityLayer.Dtos.SubCategoryDtos;
using EntityLayer.Utilities.Results.Abstract;
using System;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISubCategoryService
    {
        public Task<IDataResult<SubCategoryDto>> GetById(int subCategoryId);
        public Task<IDataResult<SubCategoryListDto>> GetByCategoryId(int categoryId);
        public Task<IDataResult<SubCategoryListDto>> GetAll();
        public Task<IResult> Add(SubCategoryAddDto subCategoryAddDto);
        public Task<IResult> Update(SubCategoryUpdateDto subCategoryUpdateDto);
        public Task<IResult> DeleteById(int subCategoryId);
    }
}