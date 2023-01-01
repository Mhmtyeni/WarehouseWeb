using AutoMapper;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.ProductDtos;
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
    public class ProductManager : ManagerBase, IProductService
    {
        public ProductManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IResult> Add(ProductAddDto productAddDto)
        {
            var product = Mapper.Map<Product>(productAddDto);
            await UnitOfWork.Product.AddAsync(product);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla eklenmiştir.");
        }

        public async Task<IResult> DeleteById(int productId)
        {
            var result = await UnitOfWork.Product.AnyAsync(a => a.Id == productId);
            if (result)
            {
                var product = await UnitOfWork.Product.GetAsync(a => a.Id == productId);
                product.IsActive = false;
                product.IsDeleted = true;
                await UnitOfWork.Product.UpdateAsync(product);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir ürün bulunamadı.");
        }
        public async Task<IResult> RemoveDeleteById(int productId)
        {
            var result = await UnitOfWork.Product.AnyAsync(a => a.Id == productId);
            if (result)
            {
                var product = await UnitOfWork.Product.GetAsync(a => a.Id == productId);
                product.IsActive = true;
                product.IsDeleted = false;
                await UnitOfWork.Product.UpdateAsync(product);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir ürün bulunamadı.");
        }

        public async Task<IDataResult<ProductListDto>> GetAll()
        {
            IQueryable<Product> query = UnitOfWork.Product.GetAsQueryable();
            query = query.Where(x => x.IsActive == true && x.IsDeleted == false).
                Include(x => x.Brand).
                Include(x => x.Currency).
                Include(x => x.Unit).
                Include(x => x.SubCategory).
                Include(x => x.SubShelf).
                ThenInclude(sub => sub.Shelf).OrderByDescending(x=>x.CreatedDate);
            var product = await query.ToListAsync();
            if (product != null)
            {
                return new DataResult<ProductListDto>(ResultStatus.Success, new ProductListDto
                {
                    Products = product,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProductListDto>(ResultStatus.Error, "Böyle bir ürün bulunamadı.", null);
        }
        public async Task<IDataResult<ProductListDto>> GetAllDeleted()
        {
            IQueryable<Product> query = UnitOfWork.Product.GetAsQueryable();
            query = query.Where(x => x.IsActive == false && x.IsDeleted == true)
                .Include(x => x.Brand)
                .Include(x => x.Currency)
                .Include(x => x.Unit)
                .Include(x => x.SubCategory)
                .Include(x => x.SubShelf).ThenInclude(sub => sub.Shelf).OrderByDescending(x => x.CreatedDate);
            var products = await query.ToListAsync();
            if (products != null)
            {
                return new DataResult<ProductListDto>(ResultStatus.Success, new ProductListDto
                {
                    Products = products,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProductListDto>(ResultStatus.Error, "Böyle bir ürün bulunamadı.", null);
        }
        public async Task<IDataResult<ProductListDto>> GetAllCriticalStock()
        {
            IQueryable<Product> query = UnitOfWork.Product.GetAsQueryable();
            query = query.Where(x => x.Stock - x.CriticalStock <= 0)
                .Include(x => x.Brand)
                .Include(x => x.Currency)
                .Include(x => x.Unit)
                .Include(x => x.SubCategory)
                .Include(x => x.SubShelf).ThenInclude(sub => sub.Shelf).OrderByDescending(x => x.CreatedDate);
            var products = await query.ToListAsync();
            if (products != null)
            {
                return new DataResult<ProductListDto>(ResultStatus.Success, new ProductListDto
                {
                    Products = products,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProductListDto>(ResultStatus.Error, "Böyle bir ürün bulunamadı.", null);
        }
        public async Task<IDataResult<ProductListDto>> SearchByKeyword(string keyword)
        {
            string normalizedKeyword = "";
            if (keyword != "")
                normalizedKeyword = keyword.ToLower();
            var query = UnitOfWork.Product.GetAsQueryable();
            query = query.Where(
            x => x.Name.ToLower().Contains(normalizedKeyword) && x.IsActive == true && x.IsDeleted == false ||
            x.Brand.Name.ToLower().Contains(normalizedKeyword) && x.IsActive == true && x.IsDeleted == false ||
            x.SubCategory.Name.ToLower().Contains(normalizedKeyword) && x.IsActive == true && x.IsDeleted == false ||
            x.Code.ToString().Contains(normalizedKeyword) && x.IsActive == true && x.IsDeleted == false).Include(x => x.Brand).Include(x => x.Unit).Include(x => x.Currency).Include(x => x.SubCategory).Include(x => x.SubShelf).ThenInclude(sub => sub.Shelf).OrderByDescending(x => x.CreatedDate);
            var products = await query.ToListAsync();
            if (products != null)
            {
                return new DataResult<ProductListDto>(ResultStatus.Success, new ProductListDto
                {
                    Products = products,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProductListDto>(ResultStatus.Error, "Böyle bir ürün bulunamadı.", null);
        }
        public async Task<IDataResult<ProductListDto>> GetByBrandId(int brandId)
        {
            var product = await UnitOfWork.Product.GetAllAsync(x => x.BrandId == brandId, x => x.Brand, x => x.Currency, x => x.SubCategory);
            if (product != null)
            {
                return new DataResult<ProductListDto>(ResultStatus.Success, new ProductListDto
                {
                    Products = product,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProductListDto>(ResultStatus.Error, "Böyle bir ürün bulunamadı.", null);
        }

        public async Task<IDataResult<ProductListDto>> GetByCurrencyId(int currencyId)
        {
            var product = await UnitOfWork.Product.GetAllAsync(x => x.CurrencyId == currencyId, x => x.Brand, x => x.Currency, x => x.SubCategory);
            if (product != null)
            {
                return new DataResult<ProductListDto>(ResultStatus.Success, new ProductListDto
                {
                    Products = product,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProductListDto>(ResultStatus.Error, "Böyle bir ürün bulunamadı.", null);
        }

        public async Task<IDataResult<ProductDto>> GetById(int productId)
        {
            var product = await UnitOfWork.Product.GetAsync(x => x.Id == productId, x => x.SubCategory, x => x.SubShelf);
            if (product != null)
            {
                return new DataResult<ProductDto>(ResultStatus.Success, new ProductDto
                {
                    Product = product,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProductDto>(ResultStatus.Error, "Böyle bir ürün bulunamadı.", null);
        }

        public async Task<IDataResult<ProductListDto>> GetBySubCategoryId(int subCategoryId)
        {
            IQueryable<Product> query = UnitOfWork.Product.GetAsQueryable();
            query = query.Where(x => x.SubCategoryId == subCategoryId && x.IsActive == true && x.IsDeleted == false).Include(x => x.Brand).Include(x => x.Unit).Include(x => x.Currency).Include(x => x.SubCategory).Include(x => x.SubShelf).ThenInclude(sub => sub.Shelf).OrderByDescending(x => x.CreatedDate);
            var product = await query.ToListAsync();
            if (product != null)
            {
                return new DataResult<ProductListDto>(ResultStatus.Success, new ProductListDto
                {
                    Products = product,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProductListDto>(ResultStatus.Error, "Böyle bir ürün bulunamadı.", null);
        }

        public async Task<IResult> Update(ProductUpdateDto productUpdateDto)
        {
            var product = Mapper.Map<Product>(productUpdateDto);
            await UnitOfWork.Product.UpdateAsync(product);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla güncellenmiştir.");
        }
        public async Task<IResult> UpdateStockById(int productId, int stock, int type)
        {
            var product = await UnitOfWork.Product.GetAsync(a => a.Id == productId);
            if (type == 0)
                product.Stock -= stock;
            else
                product.Stock += stock;
            await UnitOfWork.Product.UpdateAsync(product);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla güncellenmiştir.");
        }

        public async Task<bool> CheckCodeExist(int code)
        {
            return await UnitOfWork.Product.AnyAsync(x => x.Code == code);
        }
    }
}
