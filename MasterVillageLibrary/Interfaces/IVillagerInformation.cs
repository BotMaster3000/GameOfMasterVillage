using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterVillageLibrary.Enums;

namespace MasterVillageLibrary.Interfaces
{
    public interface IVillagerInformation
    {
        string Name { get; set; }
        string ForeName { get; set; }
        Professions Profession { get; set; }
    }
}
