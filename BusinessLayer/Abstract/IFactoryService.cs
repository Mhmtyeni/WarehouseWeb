using EntityLayer.Dtos.FactoryDtos;
using EntityLayer.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IFactoryService
    {
        public Task<IDataResult<FactoryDto>> GetById(int factoryId);
        public Task<IDataResult<FactoryListDto>> GetAll();
        public Task<IResult> Add(FactoryAddDto factoryAddDto);
        public Task<IResult> Update(FactoryUpdateDto factoryUpdateDto);
        public Task<IResult> DeleteById(int factoryId);
    }
}
