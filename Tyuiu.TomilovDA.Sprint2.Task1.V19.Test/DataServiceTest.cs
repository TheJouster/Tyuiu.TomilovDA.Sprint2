using Tyuiu.TomilovDA.Sprint2.Task1.V19.Lib;

namespace Tyuiu.TomilovDA.Sprint2.Task1.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 696;
            int b = 354;
            int c = 423;
            int d = 957;
            bool[] wait = { true, false,true,false,true,false };
            bool[] result = ds.GetLogicOperations(a, b, c, d); 
            CollectionAssert.AreEqual(wait, result);
        }
    }
}