using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TempRate
{
    class Core
    {
        public static int CalculateRate(TimeSpan srtTime, int srtTemp, TimeSpan endTime, int endTemp)
        {
            var timeOne = Convert.ToInt32(srtTime);
            var timeTwo = Convert.ToInt32(endTime);
            int Rate = (timeOne - srtTemp) / (timeTwo - endTemp);

            return Rate;
        }
    }
}
