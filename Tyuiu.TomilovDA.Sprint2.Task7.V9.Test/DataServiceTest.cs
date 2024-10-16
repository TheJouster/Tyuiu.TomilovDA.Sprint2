using Tyuiu.TomilovDA.Sprint2.Task7.V9.Lib;

namespace Tyuiu.TomilovDA.Sprint2.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0.1;
            double y = 0.1;

            Assert.AreEqual(true, ds.CheckDotInShadedArea(x,y));
        }
    }
}