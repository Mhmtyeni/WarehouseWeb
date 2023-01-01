using EntityLayer.Concrete;
using EntityLayer.Dtos.OrderDtos;
using EntityLayer.Utilities.Results.Abstract;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IOrderService
    {
        public Task<IDataResult<OrderDto>> GetById(int orderId);
        public Task<IDataResult<OrderDto>> GetByUserId(int userId);
        public Task<IDataResult<OrderListDto>> GetAll();
        public Task<IDataResult<OrderListDto>> GetAllDeleted();
        public Task<IDataResult<OrderListDto>> GetAllByUserId(int userId);
        public Task<IResult> Add(OrderAddDto orderAddDto);
        public Task<IResult> Update(OrderUpdateDto orderUpdateDto);
        public Task<IResult> DeleteById(int orderId);
    }
}
