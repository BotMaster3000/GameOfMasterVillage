using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterVillageLibrary.Enums;

namespace MasterVillageLibrary.Interfaces
{
    public interface IResource
    {
        string Name { get; set; }
        ResourceTypes Type { get; set; }
    }
}
