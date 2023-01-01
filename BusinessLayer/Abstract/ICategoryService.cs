using EntityLayer.Concrete;
using EntityLayer.Dtos.CategoryDtos;
using EntityLayer.Utilities.Results.Abstract;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        public Task<IDataResult<CategoryDto>> GetById(int categoryId);
        public Task<IDataResult<CategoryListDto>> GetAll();
        public Task<IResult> Add(CategoryAddDto categoryAddDto);
        public Task<IResult> Update(CategoryUpdateDto categoryUpdateDto);
        public Task<IResult> DeleteById(int categoryId);
    }
}
