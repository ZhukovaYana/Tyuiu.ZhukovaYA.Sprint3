using Tyuiu.ZhukovaYA.Sprint3.Task7.V10.Lib;

namespace Tyuiu.ZhukovaYA.Sprint3.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] doubles = new double[1];
            doubles[0] = 5.485;
            CollectionAssert.AreEqual(doubles, ds.GetMassFunction(1, 1));
        }
    }
}