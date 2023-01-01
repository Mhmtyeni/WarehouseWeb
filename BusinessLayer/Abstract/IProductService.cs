using EntityLayer.Concrete;
using EntityLayer.Dtos.ProductDtos;
using EntityLayer.Utilities.Results.Abstract;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProductService
    {
        public Task<IDataResult<ProductDto>> GetById(int productId);
        public Task<IDataResult<ProductListDto>> GetByCurrencyId(int currencyId);
        public Task<bool> CheckCodeExist(int code);
        public Task<IDataResult<ProductListDto>> GetByBrandId(int brandId);
        public Task<IDataResult<ProductListDto>> GetBySubCategoryId(int subCategoryId);
        public Task<IDataResult<ProductListDto>> GetAll();
        public Task<IDataResult<ProductListDto>> GetAllDeleted();
        public Task<IDataResult<ProductListDto>> GetAllCriticalStock();
        public Task<IDataResult<ProductListDto>> SearchByKeyword(string keyword);
        public Task<IResult> Add(ProductAddDto productAddDto);
        public Task<IResult> Update(ProductUpdateDto productUpdateDto);
        public Task<IResult> UpdateStockById(int productId, int stock, int type);
        public Task<IResult> DeleteById(int productId);
        public Task<IResult> RemoveDeleteById(int productId);

    }
}
