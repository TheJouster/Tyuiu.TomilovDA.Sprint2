using Tyuiu.TomilovDA.Sprint2.Task0.V25.Lib;

namespace Tyuiu.TomilovDA.Sprint2.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int x = 205;
            int y = 159;
            bool[] res = new bool[6];

            res = ds.GetCompareOperations(x, y);
            bool[] exp = { true, true, true, false, false, false };
            CollectionAssert.AreEqual(res, exp);
        }
    }
}