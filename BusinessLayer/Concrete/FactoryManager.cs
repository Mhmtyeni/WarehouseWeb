using AutoMapper;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.FactoryDtos;
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
    public class FactoryManager : ManagerBase, IFactoryService
    {
        public FactoryManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IResult> Add(FactoryAddDto factoryAddDto)
        {
            var factory = Mapper.Map<Factory>(factoryAddDto);
            await UnitOfWork.Factory.AddAsync(factory);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla eklenmiştir.");
        }

        public async Task<IResult> DeleteById(int factoryId)
        {
            var result = await UnitOfWork.Factory.AnyAsync(a => a.Id == factoryId);
            if (result)
            {
                var factory = await UnitOfWork.Factory.GetAsync(a => a.Id == factoryId);
                factory.IsActive = false;
                factory.IsDeleted = true;
                await UnitOfWork.Factory.UpdateAsync(factory);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir fabrika bulunamadı.");
        }

        public async Task<IDataResult<FactoryListDto>> GetAll()
        {
            var factory = await UnitOfWork.Factory.GetAllAsync(x => x.IsActive == true && x.IsDeleted == false, x=>x.Projects);
            if (factory != null)
            {
                return new DataResult<FactoryListDto>(ResultStatus.Success, new FactoryListDto
                {
                    Factories = factory,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<FactoryListDto>(ResultStatus.Error, "Böyle bir fabrika bulunamadı.", null);
        }

        public async Task<IDataResult<FactoryDto>> GetById(int factoryId)
        {
            var factory = await UnitOfWork.Factory.GetAsync(x => x.Id == factoryId, null);
            if (factory != null)
            {
                return new DataResult<FactoryDto>(ResultStatus.Success, new FactoryDto
                {
                    Factory = factory,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<FactoryDto>(ResultStatus.Error, "Böyle bir fabrika bulunamadı.", null);
        }

        public async Task<IResult> Update(FactoryUpdateDto factoryUpdateDto)
        {
            var factory = Mapper.Map<Factory>(factoryUpdateDto);
            await UnitOfWork.Factory.UpdateAsync(factory);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla güncellenmiştir.");
        }
    }
}
