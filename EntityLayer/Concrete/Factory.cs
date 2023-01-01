using SharedLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Factory : EntityBase, IEntity
    {
        public string Name { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
}
