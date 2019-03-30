using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterVillageLibrary.Interfaces
{
    public interface IVillageInformation
    {
        string Name { get; set; }
        IStockpile Stockpile { get; set; }
        IWorldTime Time { get; set; }
    }
}
