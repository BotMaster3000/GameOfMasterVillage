using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterVillageLibrary.Interfaces
{
    public interface IVillage
    {
        IVillageInformation VillageInformation { get; set; }
        IEnumerable<IVillager> Villagers { get; set; }
    }
}
