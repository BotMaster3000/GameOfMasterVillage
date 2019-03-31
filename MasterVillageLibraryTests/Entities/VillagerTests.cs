using Microsoft.VisualStudio.TestTools.UnitTesting;
using MasterVillageLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterVillageLibrary.Models;
using MasterVillageLibrary.Enums;

namespace MasterVillageLibrary.Entities.Tests
{
    [TestClass]
    public class VillagerTests
    {
        [TestMethod]
        public void VillagerTest_Constructor_PropertyTest()
        {
            const string NAME = "Bobsen";
            const string FORENAME = "Bob";
            const Professions PROFESSION = Professions.Farmer;
            VillagerInformation info = new VillagerInformation(NAME, FORENAME, PROFESSION);
            Villager villager = new Villager(info);
            Assert.AreEqual(info, villager.VillagerInformation);
        }
    }
}