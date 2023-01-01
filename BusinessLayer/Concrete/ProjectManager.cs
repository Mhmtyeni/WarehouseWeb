using AutoMapper;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.ProjectDtos;
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
    public class ProjectManager : ManagerBase, IProjectService
    {
        public ProjectManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IResult> Add(ProjectAddDto projectAddDto)
        {
            var project = Mapper.Map<Project>(projectAddDto);
            await UnitOfWork.Project.AddAsync(project);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla eklenmiştir.");
        }

        public async Task<IResult> DeleteById(int projectId)
        {
            var result = await UnitOfWork.Project.AnyAsync(a => a.Id == projectId);
            if (result)
            {
                var project = await UnitOfWork.Project.GetAsync(a => a.Id == projectId);
                project.IsActive = false;
                project.IsDeleted = true;
                await UnitOfWork.Project.UpdateAsync(project);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir proje bulunamadı.");
        }

        public async Task<IDataResult<ProjectListDto>> GetAll()
        {
            var projects = await UnitOfWork.Project.GetAllAsync(x => x.IsActive == true && x.IsDeleted == false, x => x.Factory);
            if (projects != null)
            {
                return new DataResult<ProjectListDto>(ResultStatus.Success, new ProjectListDto
                {
                    Projects = projects,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProjectListDto>(ResultStatus.Error, "Böyle bir proje bulunamadı.", null);
        }

        public async Task<IDataResult<ProjectListDto>> GetByFactoryId(int factoryId)
        {
            var project = await UnitOfWork.Project.GetAllAsync(x => x.FactoryId == factoryId && x.IsActive == true && x.IsDeleted == false, null);
            if (project != null)
            {
                return new DataResult<ProjectListDto>(ResultStatus.Success, new ProjectListDto
                {
                    Projects = project,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProjectListDto>(ResultStatus.Error, "Böyle bir proje bulunamadı.", null);
        }

        public async Task<IDataResult<ProjectDto>> GetById(int projectId)
        {
            var project = await UnitOfWork.Project.GetAsync(x => x.Id == projectId, x => x.Factory);
            if (project != null)
            {
                return new DataResult<ProjectDto>(ResultStatus.Success, new ProjectDto
                {
                    Project = project,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProjectDto>(ResultStatus.Error, "Böyle bir proje bulunamadı.", null);
        }

        public async Task<IResult> Update(ProjectUpdateDto projectUpdateDto)
        {
            var project = Mapper.Map<Project>(projectUpdateDto);
            await UnitOfWork.Project.UpdateAsync(project);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla güncellenmiştir.");
        }
    }
}
