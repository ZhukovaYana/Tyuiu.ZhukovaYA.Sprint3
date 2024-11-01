using Tyuiu.ZhukovaYA.Sprint3.Task0.V6.Lib;

namespace Tyuiu.ZhukovaYA.Sprint3.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(ds.GetMultiplySeries(0,3), 0.224);
        }
    }
}