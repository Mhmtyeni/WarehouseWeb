using AutoMapper;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.UnitDtos;
using EntityLayer.Utilities.Results.Abstract;
using EntityLayer.Utilities.Results.ComplexTypes;
using EntityLayer.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UnitManager : ManagerBase, IUnitService
    {
        public UnitManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IResult> Add(UnitAddDto unitAddDto)
        {
            var unit = Mapper.Map<Unit>(unitAddDto);
            await UnitOfWork.Unit.AddAsync(unit);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla eklenmiştir.");
        }

        public async Task<IResult> DeleteById(int unitId)
        {
            var result = await UnitOfWork.Unit.AnyAsync(a => a.Id == unitId);
            if (result)
            {
                var unit = await UnitOfWork.Unit.GetAsync(a => a.Id == unitId);
                unit.IsActive = false;
                unit.IsDeleted = true;
                await UnitOfWork.Unit.UpdateAsync(unit);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir raf bulunamadı.");
        }

        public async Task<IDataResult<UnitListDto>> GetAll()
        {
            var units = await UnitOfWork.Unit.GetAllAsync(x => x.IsActive == true && x.IsDeleted == false, null);
            if (units != null)
            {
                return new DataResult<UnitListDto>(ResultStatus.Success, new UnitListDto
                {
                    Units = units,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<UnitListDto>(ResultStatus.Error, "Böyle bir raf bulunamadı.", null);
        }

        public async Task<IDataResult<UnitDto>> GetById(int unitId)
        {
            var unit = await UnitOfWork.Unit.GetAsync(x => x.Id == unitId, null);
            if (unit != null)
            {
                return new DataResult<UnitDto>(ResultStatus.Success, new UnitDto
                {
                    Unit = unit,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<UnitDto>(ResultStatus.Error, "Böyle bir raf bulunamadı.", null);
        }

        public async Task<IResult> Update(UnitUpdateDto unitUpdateDto)
        {
            var unit = Mapper.Map<Unit>(unitUpdateDto);
            await UnitOfWork.Unit.UpdateAsync(unit);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla güncellenmiştir.");
        }
    }
}
