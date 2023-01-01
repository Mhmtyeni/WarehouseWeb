using AutoMapper;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.CurrencyDtos;
using EntityLayer.Utilities.Results.Abstract;
using EntityLayer.Utilities.Results.ComplexTypes;
using EntityLayer.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CurrencyManager : ManagerBase, ICurrencyService
    {
        public CurrencyManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        public async Task<IResult> Add(CurrencyAddDto currencyAddDto)
        {
            var currency = Mapper.Map<Currency>(currencyAddDto);
            await UnitOfWork.Currency.AddAsync(currency);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla eklenmiştir.");
        }

        public async Task<IResult> DeleteById(int currencyId)
        {
            var result = await UnitOfWork.Currency.AnyAsync(a => a.Id == currencyId);
            if (result)
            {
                var currency = await UnitOfWork.Currency.GetAsync(a => a.Id == currencyId);
                currency.IsActive = false;
                currency.IsDeleted = true;
                await UnitOfWork.Currency.UpdateAsync(currency);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir para birimi bulunamadı.");
        }

        public async Task<IDataResult<CurrencyListDto>> GetAll()
        {
            var currencies = await UnitOfWork.Currency.GetAllAsync(x => x.IsActive == true && x.IsDeleted == false, null);
            if (currencies != null)
            {
                return new DataResult<CurrencyListDto>(ResultStatus.Success, new CurrencyListDto
                {
                    Currencies = currencies,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CurrencyListDto>(ResultStatus.Error, "Böyle bir para birimi bulunamadı.", null);
        }

        public async Task<IDataResult<CurrencyDto>> GetById(int currencyId)
        {
            var currency = await UnitOfWork.Currency.GetAsync(x => x.Id == currencyId, null);
            if (currency != null)
            {
                return new DataResult<CurrencyDto>(ResultStatus.Success, new CurrencyDto
                {
                    Currency = currency,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CurrencyDto>(ResultStatus.Error, "Böyle bir sipariş bulunamadı.", null);
        }

        public async Task<IResult> Update(CurrencyUpdateDto currencyUpdateDto)
        {
            var currency = Mapper.Map<Currency>(currencyUpdateDto);
            await UnitOfWork.Currency.UpdateAsync(currency);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla güncellenmiştir.");
        }
    }
}
