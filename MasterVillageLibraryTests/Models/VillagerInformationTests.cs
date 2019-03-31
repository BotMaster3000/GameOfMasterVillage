using Microsoft.VisualStudio.TestTools.UnitTesting;
using MasterVillageLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterVillageLibrary.Enums;

namespace MasterVillageLibrary.Models.Tests
{
    [TestClass]
    public class VillagerInformationTests
    {
        [TestMethod]
        public void VillagerInformationTest_Constructor_PropertyTest()
        {
            const string name = "Bobsen";
            const string foreName = "Bob";
            const Professions profession = Professions.Farmer;
            VillagerInformation information = new VillagerInformation(name, foreName, profession);
            Assert.AreEqual(name, information.Name);
            Assert.AreEqual(foreName, information.ForeName);
            Assert.AreEqual(profession, information.Profession);
        }
    }
}