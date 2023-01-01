using AutoMapper;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.ProductLogDtos;
using EntityLayer.Utilities.Results.Abstract;
using EntityLayer.Utilities.Results.ComplexTypes;
using EntityLayer.Utilities.Results.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductLogManager : ManagerBase, IProductLogService
    {
        public ProductLogManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IResult> Add(ProductLogAddDto productLogAddDto)
        {
            var productLog = Mapper.Map<ProductLog>(productLogAddDto);
            await UnitOfWork.ProductLog.AddAsync(productLog);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla eklenmiştir.");
        }

        public async Task<IResult> DeleteById(int productLogId)
        {
            var result = await UnitOfWork.ProductLog.AnyAsync(a => a.Id == productLogId);
            if (result)
            {
                var productLog = await UnitOfWork.ProductLog.GetAsync(a => a.Id == productLogId);
                productLog.IsActive = false;
                productLog.IsDeleted = true;
                await UnitOfWork.ProductLog.UpdateAsync(productLog);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir raf bulunamadı.");
        }

        public async Task<IDataResult<ProductLogListDto>> GetAll()
        {
            IQueryable<ProductLog> query = UnitOfWork.ProductLog.GetAsQueryable();
            query = query.Include(x => x.Product);
            var productLog = await query.OrderByDescending(x => x.CreatedDate).ToListAsync();
            if (productLog != null)
            {
                return new DataResult<ProductLogListDto>(ResultStatus.Success, new ProductLogListDto
                {
                    ProductLogs = productLog,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProductLogListDto>(ResultStatus.Error, "Böyle bir ürün bulunamadı.", null);
        }

        public async Task<IDataResult<ProductLogListDto>> GetAllByProductId(int productId)
        {
            var productLogs = await UnitOfWork.ProductLog.GetAllAsync(x => x.IsActive == true && x.IsDeleted == false && x.ProductId == productId, x => x.Product,x=>x.Product.Unit);          
            if (productLogs != null)
            {
                return new DataResult<ProductLogListDto>(ResultStatus.Success, new ProductLogListDto
                {
                    ProductLogs = productLogs,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProductLogListDto>(ResultStatus.Error, "Böyle bir raf bulunamadı.", null);
        }

        public async Task<IDataResult<ProductLogDto>> GetById(int productLogId)
        {
            var productLog = await UnitOfWork.ProductLog.GetAsync(x => x.Id == productLogId, null);
            if (productLog != null)
            {
                return new DataResult<ProductLogDto>(ResultStatus.Success, new ProductLogDto
                {
                    ProductLog = productLog,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProductLogDto>(ResultStatus.Error, "Böyle bir raf bulunamadı.", null);
        }

        public async Task<IResult> Update(ProductLogUpdateDto productUpdateDto)
        {
            var productLog = Mapper.Map<ProductLog>(productUpdateDto);
            await UnitOfWork.ProductLog.UpdateAsync(productLog);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla güncellenmiştir.");
        }
    }
}
