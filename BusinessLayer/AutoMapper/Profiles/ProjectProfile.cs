using AutoMapper;
using EntityLayer.Concrete;
using EntityLayer.Dtos.ProjectDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.AutoMapper.Profiles
{
    public class ProjectProfile : Profile
    {
        public ProjectProfile()
        {
            CreateMap<ProjectAddDto, Project>();
            CreateMap<ProjectUpdateDto, Project>();
        }
    }
}
