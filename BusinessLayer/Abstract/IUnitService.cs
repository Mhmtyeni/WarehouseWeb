using EntityLayer.Dtos.UnitDtos;
using EntityLayer.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUnitService
    {
        public Task<IDataResult<UnitDto>> GetById(int unitId);
        public Task<IDataResult<UnitListDto>> GetAll();
        public Task<IResult> Add(UnitAddDto unitAddDto);
        public Task<IResult> Update(UnitUpdateDto unitUpdateDto);
        public Task<IResult> DeleteById(int unitId);
    }
}
