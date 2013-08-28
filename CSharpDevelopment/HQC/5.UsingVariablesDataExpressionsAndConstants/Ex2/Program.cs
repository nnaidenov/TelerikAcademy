using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        public void PrintStatistics(double[] statisticData, int dataLenght)
        {
            double max = 0;
            for (int i = 0; i < dataLenght; i++)
            {
                if (statisticData[i] > max)
                {
                    max = statisticData[i];
                }
            }

            PrintMax(max);

            double min = 0;
            for (int i = 0; i < dataLenght; i++)
            {
                if (statisticData[i] < min)
                {
                    min = statisticData[i];
                }
            }

            PrintMin(min);

            double sum = 0;
            for (int i = 0; i < dataLenght; i++)
            {
                sum += statisticData[i];
            }

            PrintAvg(sum / dataLenght);
        }
    }
}


