using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZhukovaYA.Sprint3.Task0.V6.Lib
{
    public class DataService : ISprint3Task0V6
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        { 
            double result = 1;
            for (int i = startValue; i < stopValue; i++) 
            {
                result *= (1/Math.Pow((Math.Cos(5)+1),2));
            }
            return Math.Round(result,3);
        }
    }
}
