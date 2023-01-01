using AutoMapper;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.OrderDtos;
using EntityLayer.Utilities.Results.Abstract;
using EntityLayer.Utilities.Results.ComplexTypes;
using EntityLayer.Utilities.Results.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class OrderManager : ManagerBase, IOrderService
    {
        public OrderManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IResult> Add(OrderAddDto orderAddDto)
        {
            var order = Mapper.Map<Order>(orderAddDto);
            await UnitOfWork.Order.AddAsync(order);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla eklenmiştir.");
        }

        public async Task<IResult> DeleteById(int orderId)
        {
            var result = await UnitOfWork.Order.AnyAsync(a => a.Id == orderId);
            if (result)
            {
                var order = await UnitOfWork.Order.GetAsync(a => a.Id == orderId);
                order.IsActive = false;
                order.IsDeleted = true;
                await UnitOfWork.Order.UpdateAsync(order);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir sipariş bulunamadı.");
        }

        public async Task<IDataResult<OrderListDto>> GetAll()
        {
            IQueryable<Order> query = UnitOfWork.Order.GetAsQueryable();
            query = query.Where(x => x.IsActive == true).Include(x => x.AppUser)
                .Include(x => x.OrderBaskets)
                .ThenInclude(x => x.Product)
                .ThenInclude(x => x.SubShelf)
                .ThenInclude(x => x.Shelf);
            var order = await query.ToListAsync();
            if (order != null)
            {
                return new DataResult<OrderListDto>(ResultStatus.Success, new OrderListDto
                {
                    Orders = order,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<OrderListDto>(ResultStatus.Error, "Böyle bir sipariş bulunamadı.", null);
        }
        public async Task<IDataResult<OrderListDto>> GetAllDeleted()
        {
            IQueryable<Order> query = UnitOfWork.Order.GetAsQueryable();
            query = query.Where(x => x.IsActive == false).Include(x => x.AppUser)
                 .Include(x => x.OrderBasketLogs).ThenInclude(x => x.Product).ThenInclude(x => x.Brand)
                 .Include(x => x.OrderBasketLogs).ThenInclude(x => x.Product).ThenInclude(x => x.SubShelf).ThenInclude(x => x.Shelf)
             .Include(x => x.OrderBaskets).ThenInclude(x => x.Product).ThenInclude(x => x.Brand)
             .Include(x => x.OrderBaskets).ThenInclude(x => x.Product).ThenInclude(x => x.SubShelf).ThenInclude(x => x.Shelf).OrderByDescending(x=>x.CreatedDate);
            var order = await query.ToListAsync();
            if (order != null)
            {
                return new DataResult<OrderListDto>(ResultStatus.Success, new OrderListDto
                {
                    Orders = order,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<OrderListDto>(ResultStatus.Error, "Böyle bir sipariş bulunamadı.", null);
        }
        public async Task<IDataResult<OrderListDto>> GetAllByUserId(int userId)
        {
            IQueryable<Order> query = UnitOfWork.Order.GetAsQueryable();
            query = query.Where(x => x.AppUserId == userId).Include(x => x.AppUser)
                .Include(x => x.OrderBasketLogs)
                .ThenInclude(x => x.Product)
                .ThenInclude(x => x.SubShelf)
                .ThenInclude(x => x.Shelf)
                .Include(x => x.OrderBaskets)
                .ThenInclude(x => x.Product)
                .ThenInclude(x => x.SubShelf)
                .ThenInclude(x => x.Shelf);
            var order = await query.ToListAsync();
            if (order != null)
            {
                return new DataResult<OrderListDto>(ResultStatus.Success, new OrderListDto
                {
                    Orders = order,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<OrderListDto>(ResultStatus.Error, "Böyle bir sipariş bulunamadı.", null);
        }
        public async Task<IDataResult<OrderDto>> GetById(int orderId)
        {
            IQueryable<Order> query = UnitOfWork.Order.GetAsQueryable();
            query = query.Where(x => x.Id == orderId).Include(x => x.AppUser)
                .Include(x => x.OrderBasketLogs).ThenInclude(x => x.Product).ThenInclude(x => x.Brand)
                .Include(x => x.OrderBasketLogs).ThenInclude(x => x.Product).ThenInclude(x => x.SubShelf).ThenInclude(x => x.Shelf)
            .Include(x => x.OrderBaskets).ThenInclude(x => x.Product).ThenInclude(x => x.Brand)
            .Include(x => x.OrderBaskets).ThenInclude(x => x.Product).ThenInclude(x => x.SubShelf).ThenInclude(x => x.Shelf);
            var order = await query.FirstOrDefaultAsync();
            if (order != null)
            {
                return new DataResult<OrderDto>(ResultStatus.Success, new OrderDto
                {
                    Order = order,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<OrderDto>(ResultStatus.Error, "Böyle bir sipariş bulunamadı.", null);
        }

        public async Task<IDataResult<OrderDto>> GetByUserId(int userId)
        {
            IQueryable<Order> query = UnitOfWork.Order.GetAsQueryable();
            query = query.Where(x => x.AppUserId == userId && x.IsActive == true).Include(x => x.AppUser)
                .Include(x => x.OrderBaskets)
                .ThenInclude(x => x.Product)
                .ThenInclude(x => x.SubShelf)
                .ThenInclude(x => x.Shelf);
            var order = await query.OrderByDescending(x=>x.Id).FirstAsync();
            if (order != null)
            {
                return new DataResult<OrderDto>(ResultStatus.Success, new OrderDto
                {
                    Order = order,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<OrderDto>(ResultStatus.Error, "Böyle bir sipariş bulunamadı.", null);
        }

        public async Task<IResult> Update(OrderUpdateDto orderUpdateDto)
        {
            var order = Mapper.Map<Order>(orderUpdateDto);
            await UnitOfWork.Order.UpdateAsync(order);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla güncellenmiştir.");
        }
    }
}
