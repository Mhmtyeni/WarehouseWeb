using EntityLayer.Dtos.OrderBasketDtos;
using EntityLayer.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IOrderBasketService
    {
        public Task<IDataResult<OrderBasketDto>> GetByProductId(int productId);
        public Task<IDataResult<OrderBasketDto>> GetByOrderId(int orderId);
        public Task<IDataResult<OrderBasketListDto>> GetAll();
        public Task<IDataResult<OrderBasketListDto>> GetAllByOrderId(int orderId);
        public Task<IResult> Add(OrderBasketAddDto orderBasketAddDto);
        public Task<IResult> Update(OrderBasketUpdateDto orderBasketUpdateDto);
        public Task<IResult> DeleteAllByOrderId(int orderId);
        public Task<IResult> DeleteByProductId(int productId);
    }
}
