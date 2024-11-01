using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZhukovaYA.Sprint3.Task1.V18.Lib
{
    public class DataService : ISprint3Task1V18
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double result = 0;
            while (startValue < stopValue)
            {
                result += Math.Sin(startValue) * 0.0625;
                startValue++;
            }
            return Math.Round(result, 3);
        }
    }
}
