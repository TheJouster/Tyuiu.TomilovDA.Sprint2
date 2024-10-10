using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TomilovDA.Sprint2.Task1.V19.Lib
{
    public class DataService : ISprint2Task1V19
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];
            result[0] = (a > b) | (b > c); 
            result[1] = (a >= c) & (d < c);
            result[2] = (b <= a) || (d == c);
            result[3] = (a <= b) && (b != c);
            result[4] = !(a < b);
            result[5] = (a >= b) ^ (b != c);
            return result;
        }
    }
}
