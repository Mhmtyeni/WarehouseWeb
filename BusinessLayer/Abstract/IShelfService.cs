using EntityLayer.Concrete;
using EntityLayer.Dtos.ShelfDtos;
using EntityLayer.Utilities.Results.Abstract;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IShelfService
    {
        public Task<IDataResult<ShelfDto>> GetById(int shelfId);
        public Task<IDataResult<ShelfListDto>> GetAll();
        public Task<IResult> Add(ShelfAddDto shelfAddDto);
        public Task<IResult> Update(ShelfUpdateDto shelfUpdateDto);
        public Task<IResult> DeleteById(int shelfId);
    }
}

