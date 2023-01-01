using EntityLayer.Concrete;
using EntityLayer.Dtos.OrderBasketLogDtos;
using EntityLayer.Utilities.Results.Abstract;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IOrderBasketLogService
    {
        public Task<IDataResult<OrderBasketLogDto>> GetById(int orderBasketLogId);
        public Task<IDataResult<OrderBasketLogDto>> GetByOrderId(int orderId);
        public Task<IDataResult<OrderBasketLogListDto>> GetAll();
        public Task<IResult> Add(OrderBasketLogAddDto orderBasketLogAddDto);
        public Task<IResult> DeleteById(int orderBasketLogId);
    }
}
