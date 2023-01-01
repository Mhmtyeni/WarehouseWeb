using EntityLayer.Concrete;
using EntityLayer.Dtos.SubShelfDtos;
using EntityLayer.Utilities.Results.Abstract;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISubShelfService
    {
        public Task<IDataResult<SubShelfDto>> GetById(int subShelfId);
        public Task<IDataResult<SubShelfListDto>> GetByShelfId(int shelfId);
        public Task<IDataResult<SubShelfListDto>> GetAll();
        public Task<IResult> Add(SubShelfAddDto subShelfAddDto);
        public Task<IResult> Update(SubShelfUpdateDto subShelfUpdateDto);
        public Task<IResult> DeleteById(int subShelfId);
    }
}