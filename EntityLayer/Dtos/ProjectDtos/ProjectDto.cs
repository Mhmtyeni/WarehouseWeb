using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dtos.ProjectDtos
{
    public class ProjectDto : DtoGetBase
    {
        public Project Project { get; set; }
    }
}
