﻿using Tyuiu.ZhukovaYA.Sprint3.Task1.V18.Lib;

namespace Tyuiu.ZhukovaYA.Sprint3.Task1.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(0.121, ds.GetSumSeries(1, 15));
        }
    }
}