using AutoMapper;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.ShelfDtos;
using EntityLayer.Utilities.Results.Abstract;
using EntityLayer.Utilities.Results.ComplexTypes;
using EntityLayer.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ShelfManager : ManagerBase,  IShelfService
    {
        public ShelfManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        public async Task<IResult> Add(ShelfAddDto shelfAddDto)
        {
            var shelf = Mapper.Map<Shelf>(shelfAddDto);
            await UnitOfWork.Shelf.AddAsync(shelf);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla eklenmiştir.");
        }

        public async Task<IResult> DeleteById(int shelfId)
        {
            var result = await UnitOfWork.Shelf.AnyAsync(a => a.Id == shelfId);
            if (result)
            {
                var shelf = await UnitOfWork.Shelf.GetAsync(a => a.Id == shelfId);
                shelf.IsActive = false;
                shelf.IsDeleted = true;
                await UnitOfWork.Shelf.UpdateAsync(shelf);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir raf bulunamadı.");
        }

        public async Task<IDataResult<ShelfListDto>> GetAll()
        {
            var shelves = await UnitOfWork.Shelf.GetAllAsync(x => x.IsActive == true && x.IsDeleted == false, null);
            if (shelves != null)
            {
                return new DataResult<ShelfListDto>(ResultStatus.Success, new ShelfListDto
                {
                    Shelves = shelves,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ShelfListDto>(ResultStatus.Error, "Böyle bir raf bulunamadı.", null);
        }

        public async Task<IDataResult<ShelfDto>> GetById(int shelfId)
        {
            var shelf = await UnitOfWork.Shelf.GetAsync(x => x.Id == shelfId, null);
            if (shelf != null)
            {
                return new DataResult<ShelfDto>(ResultStatus.Success, new ShelfDto
                {
                    Shelf = shelf,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ShelfDto>(ResultStatus.Error, "Böyle bir raf bulunamadı.", null);
        }

        public async Task<IResult> Update(ShelfUpdateDto shelfUpdateDto)
        {
            var shelf = Mapper.Map<Shelf>(shelfUpdateDto);
            await UnitOfWork.Shelf.UpdateAsync(shelf);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla güncellenmiştir.");
        }
    }
}
