using Tyuiu.ZhukovaYA.Sprint3.Task4.V14.Lib;

namespace Tyuiu.ZhukovaYA.Sprint3.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(-0.642, ds.Calculate(-1,1));
        }
    }
}