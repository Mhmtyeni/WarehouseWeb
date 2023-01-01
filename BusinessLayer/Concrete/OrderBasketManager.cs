using AutoMapper;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.OrderBasketDtos;
using EntityLayer.Utilities.Results.Abstract;
using EntityLayer.Utilities.Results.ComplexTypes;
using EntityLayer.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class OrderBasketManager : ManagerBase, IOrderBasketService
    {
        public OrderBasketManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IResult> Add(OrderBasketAddDto orderBasketAddDto)
        {
            var orderBasket = Mapper.Map<OrderBasket>(orderBasketAddDto);
            await UnitOfWork.OrderBasket.AddAsync(orderBasket);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla eklenmiştir.");
        }
        public async Task<IResult> DeleteAllByOrderId(int orderId)
        {
            var result = await UnitOfWork.OrderBasket.GetAllAsync(a => a.OrderId == orderId);
            if (result.Count > 0)
            {
                foreach (var item in result)
                    await UnitOfWork.OrderBasket.DeleteAsync(item);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir sipariş bulunamadı.");
        }

        public async Task<IResult> DeleteByProductId(int productId)
        {
            var result = await UnitOfWork.OrderBasket.AnyAsync(a => a.ProductId == productId);
            if (result)
            {
                var basket = await UnitOfWork.OrderBasket.GetAsync(a => a.ProductId == productId);
                await UnitOfWork.OrderBasket.DeleteAsync(basket);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir ürün bulunamadı.");
        }

        public async Task<IDataResult<OrderBasketListDto>> GetAll()
        {
            var basket = await UnitOfWork.OrderBasket.GetAllAsync(null, a => a.Order, a => a.Product);
            if (basket != null)
            {
                return new DataResult<OrderBasketListDto>(ResultStatus.Success, new OrderBasketListDto
                {
                    OrderBaskets = basket,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<OrderBasketListDto>(ResultStatus.Error, "Sepette böyle bir sipariş bulunamadı.", null);
        }
        public async Task<IDataResult<OrderBasketDto>> GetByOrderId(int orderId)
        {
            var basket = await UnitOfWork.OrderBasket.GetAsync(a => a.OrderId == orderId, a => a.Order, a => a.Product);
            if (basket != null)
            {
                return new DataResult<OrderBasketDto>(ResultStatus.Success, new OrderBasketDto
                {
                    OrderBasket = basket,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<OrderBasketDto>(ResultStatus.Error, "Sepette böyle bir sipariş bulunamadı.", null);
        }
        public async Task<IDataResult<OrderBasketDto>> GetByProductId(int productId)
        {
            var basket = await UnitOfWork.OrderBasket.GetAsync(a => a.ProductId == productId, a => a.Order, a => a.Product);
            if (basket != null)
            {
                return new DataResult<OrderBasketDto>(ResultStatus.Success, new OrderBasketDto
                {
                    OrderBasket = basket,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<OrderBasketDto>(ResultStatus.Error, "Sepette böyle bir ürün bulunamadı.", null);
        }

        public async Task<IResult> Update(OrderBasketUpdateDto basketUpdateDto)
        {
            var basket = Mapper.Map<OrderBasket>(basketUpdateDto);
            await UnitOfWork.OrderBasket.UpdateAsync(basket);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla güncellenmiştir.");
        }

        public async Task<IDataResult<OrderBasketListDto>> GetAllByOrderId(int orderId)
        {
            var basket = await UnitOfWork.OrderBasket.GetAllAsync(x => x.OrderId == orderId, a => a.Order, a => a.Product);
            if (basket != null)
            {
                return new DataResult<OrderBasketListDto>(ResultStatus.Success, new OrderBasketListDto
                {
                    OrderBaskets = basket,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<OrderBasketListDto>(ResultStatus.Error, "Sepette böyle bir sipariş bulunamadı.", null);
        }
    }
}
