using EntityLayer.Dtos.ProductLogDtos;
using EntityLayer.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProductLogService
    {
        public Task<IDataResult<ProductLogDto>> GetById(int productLogId);
        public Task<IDataResult<ProductLogListDto>> GetAllByProductId(int productId);
        public Task<IResult> Add(ProductLogAddDto productLogAddDto);
        public Task<IResult> Update(ProductLogUpdateDto productUpdateDto);
        public Task<IResult> DeleteById(int productLogId);
        public Task<IDataResult<ProductLogListDto>> GetAll();
    }
}
