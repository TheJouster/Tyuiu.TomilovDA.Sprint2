using Tyuiu.TomilovDA.Sprint2.Task1.V19.Lib;
namespace Tyuiu.TomilovDA.Sprint2.Task1.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 696;
            int b = 354;
            int c = 423;
            int d = 957;
            Console.Title = "Спринт #2 | Выполнил: Томилов Дмитрий Алексеевич | ПКТб-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Логические операции                                                     *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Томилов Дмитрий Алексеевич | ПКТб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Написать программу из операций сравнений (==, !=, <, >, <=, >=, последова*");
            Console.WriteLine("*ательность можно чередовать, но использовать один раз в выражении) и логи*");
            Console.WriteLine("*ических операций (|, &, ||, &&, !, ^, последовательность операций не долж*");
            Console.WriteLine("*жна нарушаться), а также арифметических выражений, которая вернет логичес*");
            Console.WriteLine("*скую последовательность(массив): (True, False, True, False, True, False),*");
            Console.WriteLine("*, при a = 696, b = 354, c = 423, d = 957                                 *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
                
            Console.WriteLine("a = "+ a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.GetLogicOperations(a,b,c,d);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
            Console.ReadKey();
        }
    }
}