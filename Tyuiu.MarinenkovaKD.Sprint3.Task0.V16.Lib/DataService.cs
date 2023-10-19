using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MarinenkovaKD.Sprint3.Task0.V16.Lib
{
    public class DataService : ISprint3Task0V16
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double sumSeries = 1;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                sumSeries = sumSeries * (Math.Pow((1.0 / i), -3));
            }
            return Math.Round(sumSeries,3);
        }
    }
}
