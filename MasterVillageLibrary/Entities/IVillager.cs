using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterVillageLibrary.Interfaces;

namespace MasterVillageLibrary.Entities
{
    public class Villager : IVillager
    {
        public IVillagerInformation VillagerInformation { get; set; }

        public Villager(IVillagerInformation information)
        {
            VillagerInformation = information;
        }
    }
}
