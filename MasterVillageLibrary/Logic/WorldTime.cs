using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterVillageLibrary.Interfaces;

namespace MasterVillageLibrary.Logic
{
    public class WorldTime : IWorldTime
    {
        public int Hour { get; private set; }
        public int Day { get; private set; }
        public int Month { get; private set; }
        public int Year { get; private set; }

        private const int HOURS_PER_DAY = 24;
        private const int DAYS_PER_MONTH = 30;
        private const int MONTH_PER_YEAR = 12;

        public WorldTime(int year, int month, int day, int hour)
        {
            Year = year;
            Month = month;
            Day = day;
            Hour = hour;
        }

        public void NextHour()
        {
            ++Hour;
            if (IsNextDay())
            {
                NextDay();
                Hour = 0;
            }
        }

        private bool IsNextDay()
        {
            return Hour >= HOURS_PER_DAY;
        }

        public void NextDay()
        {
            ++Day;
            if (IsNextMonth())
            {
                NextMonth();
                Day = 1;
            }
        }

        private bool IsNextMonth()
        {
            return Day >= DAYS_PER_MONTH;
        }

        public void NextMonth()
        {
            ++Month;
            if (IsNextYear())
            {
                NextYear();
                Month = 1;
            }
        }

        private bool IsNextYear()
        {
            return Month >= MONTH_PER_YEAR;
        }

        public void NextYear()
        {
            ++Year;
        }
    }
}
