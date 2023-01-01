using AutoMapper;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.SubShelfDtos;
using EntityLayer.Utilities.Results.Abstract;
using EntityLayer.Utilities.Results.ComplexTypes;
using EntityLayer.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SubShelfManager : ManagerBase, ISubShelfService
    {
        public SubShelfManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        public async Task<IResult> Add(SubShelfAddDto subShelfAddDto)
        {
            var subShelf = Mapper.Map<SubShelf>(subShelfAddDto);
            await UnitOfWork.SubShelf.AddAsync(subShelf);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla eklenmiştir.");
        }

        public async Task<IResult> DeleteById(int subShelfId)
        {
            var result = await UnitOfWork.SubShelf.AnyAsync(a => a.Id == subShelfId);
            if (result)
            {
                var subShelf = await UnitOfWork.SubShelf.GetAsync(a => a.Id == subShelfId);
                subShelf.IsActive = false;
                subShelf.IsDeleted = true;
                await UnitOfWork.SubShelf.UpdateAsync(subShelf);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir raf bulunamadı.");
        }

        public async Task<IDataResult<SubShelfListDto>> GetAll()
        {
            var subShelves = await UnitOfWork.SubShelf.GetAllAsync(x => x.IsActive == true && x.IsDeleted == false, null);
            if (subShelves != null)
            {
                return new DataResult<SubShelfListDto>(ResultStatus.Success, new SubShelfListDto
                {
                    SubShelves = subShelves,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<SubShelfListDto>(ResultStatus.Error, "Böyle bir raf bulunamadı.", null);
        }

        public async Task<IDataResult<SubShelfDto>> GetById(int subShelfId)
        {
            var subShelf = await UnitOfWork.SubShelf.GetAsync(x => x.Id == subShelfId, x => x.Shelf);
            if (subShelf != null)
            {
                return new DataResult<SubShelfDto>(ResultStatus.Success, new SubShelfDto
                {
                    SubShelf = subShelf,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<SubShelfDto>(ResultStatus.Error, "Böyle bir raf bulunamadı.", null);
        }

        public async Task<IDataResult<SubShelfListDto>> GetByShelfId(int shelfId)
        {
            var subShelf = await UnitOfWork.SubShelf.GetAllAsync(x => x.ShelfId == shelfId && x.IsActive == true && x.IsDeleted == false, null);
            if (subShelf != null)
            {
                return new DataResult<SubShelfListDto>(ResultStatus.Success, new SubShelfListDto
                {
                    SubShelves = subShelf,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<SubShelfListDto>(ResultStatus.Error, "Böyle bir raf bulunamadı.", null);
        }

        public async Task<IResult> Update(SubShelfUpdateDto subShelfUpdateDto)
        {
            var subShelf = Mapper.Map<SubShelf>(subShelfUpdateDto);
            await UnitOfWork.SubShelf.UpdateAsync(subShelf);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla güncellenmiştir.");
        }
    }
}
