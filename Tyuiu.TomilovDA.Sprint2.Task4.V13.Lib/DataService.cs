﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TomilovDA.Sprint2.Task4.V13.Lib
{
    public class DataService : ISprint2Task4V13
    {
        public double Calculate(double x, double y)
        {

            double z = Math.Sqrt(x) * 3 > y * 2 - 20 ? x + 10 * y - (1 / x) : (x * x + Math.Pow(Math.Cos(y), 2) + 13) / (y * y - Math.Pow(Math.Sin(y), 2) + 9);

            return Math.Round(z, 3);

        }
    }
}
