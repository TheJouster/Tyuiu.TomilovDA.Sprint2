using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TomilovDA.Sprint2.Task7.V9.Lib
{
    public class DataService : ISprint2Task7V9
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if ((Math.Sin(x) > 0) && (y > 0) && (y < 0.5) )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
