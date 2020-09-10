using System;
using System.Collections.Generic;
using System.Linq;
using Statistics;


namespace Statistics
{
    
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<float> numbers)
        {

            Stats stat=new Stats();
            if(numbers.Count>0)
            {
                stat.average = numbers.Average();
                stat.min = numbers.Min();
                stat.max = numbers.Max();

            }
            else
            {
                stat.average=double.NaN;
                stat.min = double.NaN;
                stat.max = double.NaN;

            }
            return stat;

        }
    }
}
