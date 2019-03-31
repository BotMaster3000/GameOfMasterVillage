using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterVillageLibrary.Enums;
using MasterVillageLibrary.Interfaces;

namespace MasterVillageLibrary.Models
{
    public class VillagerInformation : IVillagerInformation
    {
        public string Name { get; set; }
        public string ForeName { get; set; }
        public Professions Profession { get; set; }

        public VillagerInformation(string name, string foreName, Professions profession)
        {
            Name = name;
            ForeName = foreName;
            Profession = profession;
        }
    }
}
