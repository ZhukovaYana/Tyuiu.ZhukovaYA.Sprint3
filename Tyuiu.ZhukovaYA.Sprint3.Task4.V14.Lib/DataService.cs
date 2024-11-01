using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZhukovaYA.Sprint3.Task4.V14.Lib
{
    public class DataService : ISprint3Task4V14
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 0;

            for (int i = startValue; i < stopValue; i++)
            {
                if (i == 0) break;
                res += Math.Cos(i) / Math.Sin(i);
            }
            return Math.Round(res,3);
        }
    }
}
