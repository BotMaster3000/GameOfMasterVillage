using Microsoft.VisualStudio.TestTools.UnitTesting;
using MasterVillageLibrary.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterVillageLibrary.Logic.Tests
{
    [TestClass]
    public class WorldTimeTests
    {
        private int YEAR = 100;
        private int MONTH = 10;
        private int DAY = 14;
        private int HOUR = 12;

        private void AssertAreEqual(WorldTime time, int year, int month, int day, int hour)
        {
            Assert.AreEqual(year, time.Year);
            Assert.AreEqual(month, time.Month);
            Assert.AreEqual(day, time.Day);
            Assert.AreEqual(hour, time.Hour);
        }

        [TestMethod]
        public void NextHourTest_OnlyChangeHour()
        {
            WorldTime time = new WorldTime(YEAR, MONTH, DAY, HOUR);
            time.NextHour();
            AssertAreEqual(time, YEAR, MONTH, DAY, HOUR + 1);
        }

        [TestMethod]
        public void NextDayTest_OnlyChangeDay()
        {
            WorldTime time = new WorldTime(YEAR, MONTH, DAY, HOUR);
            time.NextDay();
            AssertAreEqual(time, YEAR, MONTH, DAY + 1, HOUR);
        }

        [TestMethod]
        public void NextMonthTest_OnlyChangeMonth()
        {
            WorldTime time = new WorldTime(YEAR, MONTH, DAY, HOUR);
            time.NextMonth();
            AssertAreEqual(time, YEAR, MONTH + 1, DAY, HOUR);
        }

        [TestMethod]
        public void NextYearTest_OnlyChangeYear()
        {
            WorldTime time = new WorldTime(YEAR, MONTH, DAY, HOUR);
            time.NextYear();
            AssertAreEqual(time, YEAR + 1, MONTH, DAY, HOUR);
        }

        [TestMethod]
        public void NextHourTest_ChangeHourAndDay()
        {
            HOUR = 23;
            WorldTime time = new WorldTime(YEAR, MONTH, DAY, HOUR);
            time.NextHour();
            AssertAreEqual(time, YEAR, MONTH, DAY + 1, 0);
        }

        [TestMethod]
        public void NextHourTest_ChangeHourAndDayAndMonth()
        {
            HOUR = 23;
            DAY = 30;
            WorldTime time = new WorldTime(YEAR, MONTH, DAY, HOUR);
            time.NextHour();
            AssertAreEqual(time, YEAR, MONTH + 1, 1, 0);
        }

        [TestMethod]
        public void NextHourTest_ChangeHourAndDayAndMonthAndYear()
        {
            HOUR = 23;
            DAY = 30;
            MONTH = 12;
            WorldTime time = new WorldTime(YEAR, MONTH, DAY, HOUR);
            time.NextHour();
            AssertAreEqual(time, YEAR + 1, 1, 1, 0);
        }
    }
}