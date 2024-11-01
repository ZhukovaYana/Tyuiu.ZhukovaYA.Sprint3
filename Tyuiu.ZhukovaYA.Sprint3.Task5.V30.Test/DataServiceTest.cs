using Tyuiu.ZhukovaYA.Sprint3.Task5.V30.Lib;

namespace Tyuiu.ZhukovaYA.Sprint3.Task5.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(2, ds.GetSumSumSeries(1,1,1,2,2));
        }
    }
}