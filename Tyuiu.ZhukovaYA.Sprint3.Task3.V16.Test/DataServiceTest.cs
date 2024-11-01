using Tyuiu.ZhukovaYA.Sprint3.Task3.V16.Lib;

namespace Tyuiu.ZhukovaYA.Sprint3.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(ds.GetCharCount("ice nice ice creamcc",'c'), 6);
        }
    }
}