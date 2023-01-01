using EntityLayer.Concrete;
using EntityLayer.Dtos.CurrencyDtos;
using EntityLayer.Utilities.Results.Abstract;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICurrencyService
    {
        public Task<IDataResult<CurrencyDto>> GetById(int currencyId);
        public Task<IDataResult<CurrencyListDto>> GetAll();
        public Task<IResult> Add(CurrencyAddDto currencyAddDto);
        public Task<IResult> Update(CurrencyUpdateDto currencyUpdateDto);
        public Task<IResult> DeleteById(int currencyId);
    }
}
