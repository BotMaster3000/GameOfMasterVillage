using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterVillageLibrary.Interfaces
{
    public interface IStockpile
    {
        IDictionary<IResource, int> Resources { get; set; }
    }
}
