using AutoMapper;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.OrderBasketLogDtos;
using EntityLayer.Utilities.Results.Abstract;
using EntityLayer.Utilities.Results.ComplexTypes;
using EntityLayer.Utilities.Results.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class OrderBasketLogManager : ManagerBase, IOrderBasketLogService
    {
        public OrderBasketLogManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        public async Task<IResult> Add(OrderBasketLogAddDto orderBasketLogAddDto)
        {
            var orderBasketLog = Mapper.Map<OrderBasketLog>(orderBasketLogAddDto);
            await UnitOfWork.OrderBasketLog.AddAsync(orderBasketLog);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla eklenmiştir.");
        }

        public async Task<IResult> DeleteById(int orderBasketLogId)
        {
            var result = await UnitOfWork.OrderBasketLog.AnyAsync(a => a.Id == orderBasketLogId);
            if (result)
            {
                var orderBasketLog = await UnitOfWork.OrderBasketLog.GetAsync(a => a.Id == orderBasketLogId);
                await UnitOfWork.OrderBasketLog.DeleteAsync(orderBasketLog);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir sipariş bulunamadı.");
        }

        public async Task<IDataResult<OrderBasketLogListDto>> GetAll()
        {
            IQueryable<OrderBasketLog> query = UnitOfWork.OrderBasketLog.GetAsQueryable();
            query = query.Include(x => x.Product)
                .Include(x => x.Order)
                .ThenInclude(x => x.AppUser);
            var orderBasketLog = await query.ToListAsync();
            if (orderBasketLog != null)
            {
                return new DataResult<OrderBasketLogListDto>(ResultStatus.Success, new OrderBasketLogListDto
                {
                    OrderBasketLogs = orderBasketLog,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<OrderBasketLogListDto>(ResultStatus.Error, "Böyle bir sipariş bulunamadı.", null);
        }

        public async Task<IDataResult<OrderBasketLogDto>> GetById(int orderBasketLogId)
        {
            var orderBasketLog = await UnitOfWork.OrderBasketLog.GetAsync(x => x.Id == orderBasketLogId, null);
            if (orderBasketLog != null)
            {
                return new DataResult<OrderBasketLogDto>(ResultStatus.Success, new OrderBasketLogDto
                {
                    OrderBasketLog = orderBasketLog,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<OrderBasketLogDto>(ResultStatus.Error, "Böyle bir sipariş bulunamadı.", null);
        }

        public async Task<IDataResult<OrderBasketLogDto>> GetByOrderId(int orderId)
        {
            var orderLog = await UnitOfWork.OrderBasketLog.GetAsync(x => x.OrderId == orderId, null);
            if (orderLog != null)
            {
                return new DataResult<OrderBasketLogDto>(ResultStatus.Success, new OrderBasketLogDto
                {
                    OrderBasketLog = orderLog,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<OrderBasketLogDto>(ResultStatus.Error, "Böyle bir sipariş bulunamadı.", null);
        }
    }
}
