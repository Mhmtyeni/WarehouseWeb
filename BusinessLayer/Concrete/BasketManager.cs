using AutoMapper;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.BasketDtos;
using EntityLayer.Utilities.Results.Abstract;
using EntityLayer.Utilities.Results.ComplexTypes;
using EntityLayer.Utilities.Results.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BasketManager : ManagerBase, IBasketService
    {
        public BasketManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IResult> Add(BasketAddDto basketAddDto)
        {
            var basket = Mapper.Map<Basket>(basketAddDto);
            await UnitOfWork.Basket.AddAsync(basket);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla eklenmiştir.");
        }
        public async Task<IResult> DeleteByUserId(int userId)
        {
            var result = await UnitOfWork.Basket.AnyAsync(a => a.AppUserId == userId);

            if (result)
            {
                var basket = await UnitOfWork.Basket.GetAllAsync(a => a.AppUserId == userId);
                foreach (var item in basket)
                    await UnitOfWork.Basket.DeleteAsync(item);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir sipariş bulunamadı.");
        }

        public async Task<IResult> Delete(int productId, int userId)
        {
            var result = await UnitOfWork.Basket.AnyAsync(a => a.ProductId == productId && a.AppUserId == userId);
            if (result)
            {
                var basket = await UnitOfWork.Basket.GetAsync(a => a.ProductId == productId);
                await UnitOfWork.Basket.DeleteAsync(basket);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir ürün bulunamadı.");
        }

        public async Task<IDataResult<BasketListDto>> GetAll()
        {
            var basket = await UnitOfWork.Basket.GetAllAsync(null, a => a.AppUser, a => a.Product);
            if (basket != null)
            {
                return new DataResult<BasketListDto>(ResultStatus.Success, new BasketListDto
                {
                    Baskets = basket,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<BasketListDto>(ResultStatus.Error, "Sepette böyle bir sipariş bulunamadı.", null);
        }
        public async Task<IDataResult<BasketDto>> GetByUserId(int userId)
        {
            var basket = await UnitOfWork.Basket.GetAsync(a => a.AppUserId == userId, a => a.AppUser, a => a.Product);
            if (basket != null)
            {
                return new DataResult<BasketDto>(ResultStatus.Success, new BasketDto
                {
                    Basket = basket,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<BasketDto>(ResultStatus.Error, "Sepette böyle bir sipariş bulunamadı.", null);
        }
        public async Task<IDataResult<BasketDto>> GetByProductId(int productId)
        {
            var basket = await UnitOfWork.Basket.GetAsync(a => a.ProductId == productId, a => a.AppUser, a => a.Product);
            if (basket != null)
            {
                return new DataResult<BasketDto>(ResultStatus.Success, new BasketDto
                {
                    Basket = basket,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<BasketDto>(ResultStatus.Error, "Sepette böyle bir ürün bulunamadı.", null);
        }

        public async Task<IResult> Update(BasketUpdateDto basketUpdateDto)
        {
            var basket = Mapper.Map<Basket>(basketUpdateDto);
            await UnitOfWork.Basket.UpdateAsync(basket);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla güncellenmiştir.");
        }

        public async Task<IDataResult<BasketListDto>> GetAllByUserId(int userId)
        {
            IQueryable<Basket> query = UnitOfWork.Basket.GetAsQueryable();
            query = query.Where(x => x.AppUserId == userId).Include(x => x.Product).ThenInclude(x => x.Currency)
                .Include(x => x.Product).ThenInclude(x => x.Brand)
                .Include(x => x.Product).ThenInclude(x => x.Unit)
                .Include(x => x.AppUser);
            var basket = await query.ToListAsync();
            if (basket != null)
            {
                return new DataResult<BasketListDto>(ResultStatus.Success, new BasketListDto
                {
                    Baskets = basket,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<BasketListDto>(ResultStatus.Error, "Sepette böyle bir sipariş bulunamadı.", null);
        }
    }
}
