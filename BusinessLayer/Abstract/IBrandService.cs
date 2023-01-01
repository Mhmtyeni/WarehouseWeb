using EntityLayer.Concrete;
using EntityLayer.Dtos.BrandDtos;
using EntityLayer.Utilities.Results.Abstract;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBrandService
    {
        public Task<IDataResult<BrandDto>> GetById(int brandId);
        public Task<IDataResult<BrandListDto>> GetAll();
        public Task<IResult> Add(BrandAddDto basketAddDto);
        public Task<IResult> Update(BrandUpdateDto basketUpdateDto);
        public Task<IResult> DeleteById(int brandId);
    }
}
