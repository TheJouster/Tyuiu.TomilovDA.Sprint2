using Tyuiu.TomilovDA.Sprint2.Task3.V7.Lib;

namespace Tyuiu.TomilovDA.Sprint2.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double y = ds.Calculate(2);
            Assert.AreEqual(50, y);
        }
    }
}