using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterVillageLibrary.Interfaces
{
    public interface IWorldTime
    {
        int Hour { get; }
        int Day { get; }
        int Month { get; }
        int Year { get; }

        void NextHour();
        void NextDay();
        void NextMonth();
        void NextYear();
    }
}
