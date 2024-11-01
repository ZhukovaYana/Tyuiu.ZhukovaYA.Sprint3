using Tyuiu.ZhukovaYA.Sprint3.Task6.V21.Lib;

namespace Tyuiu.ZhukovaYA.Sprint3.Task6.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(15, ds.GetSumTheDivisors(1,4));
        }
    }
}