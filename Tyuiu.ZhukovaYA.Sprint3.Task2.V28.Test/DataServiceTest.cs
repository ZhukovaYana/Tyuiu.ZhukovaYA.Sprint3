using Tyuiu.ZhukovaYA.Sprint3.Task2.V28.Lib;

namespace Tyuiu.ZhukovaYA.Sprint3.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(0.052, ds.GetMultiplySeries(0,1));
        }
    }
}