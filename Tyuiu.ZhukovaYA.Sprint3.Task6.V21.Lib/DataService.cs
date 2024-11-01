using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZhukovaYA.Sprint3.Task6.V21.Lib
{
    public class DataService : ISprint3Task6V21
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int res = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                for (int x = 1; x <= i; x++)
                {
                    if (i % x == 0) res += x;
                }
            }
            return res;
        }
    }
}
