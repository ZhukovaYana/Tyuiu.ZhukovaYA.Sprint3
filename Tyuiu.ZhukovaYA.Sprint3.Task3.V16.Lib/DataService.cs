﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZhukovaYA.Sprint3.Task3.V16.Lib
{
    public class DataService : ISprint3Task3V16
    {
        public int GetCharCount(string value, char item)
        {
            int count = 0;
            foreach (char c in value) 
            {
            if (c == item)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
