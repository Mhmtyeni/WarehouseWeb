using EntityLayer.Concrete;
using EntityLayer.Dtos.BasketDtos;
using EntityLayer.Utilities.Results.Abstract;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBasketService
    {
        public Task<IDataResult<BasketDto>> GetByProductId(int productId);
        public Task<IDataResult<BasketDto>> GetByUserId(int userId);
        public Task<IDataResult<BasketListDto>> GetAll();
        public Task<IDataResult<BasketListDto>> GetAllByUserId(int userId);
        public Task<IResult> Add(BasketAddDto basketAddDto);
        public Task<IResult> Update(BasketUpdateDto basketUpdateDto);
        public Task<IResult> DeleteByUserId(int userId);
        public Task<IResult> Delete(int productId, int userId);
    }
}
