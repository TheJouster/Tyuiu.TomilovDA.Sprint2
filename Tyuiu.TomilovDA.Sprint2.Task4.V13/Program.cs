using Tyuiu.TomilovDA.Sprint2.Task4.V13.Lib;
namespace Tyuiu.TomilovDA.Sprint2.Task4.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Томилов Дмитрий Алексеевич | ПКТб-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тернарный оператор                                                      *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Томилов Дмитрий Алексеевич | ПКТб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Написать программу, которая вычисляет требуемое значение с использованием*");
            Console.WriteLine("*м тернарного оператора, где пользователь вводит значение переменных х,у с*");
            Console.WriteLine("*с клавиатуры, если √х * 3 > у * 2 - 20, то z = x + 10y - 1/x иначе       *");
            Console.WriteLine("*x²+cos(y)²+13 / y²-sin(y)²+9                                             *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите переменную X");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите переменную Y");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.Calculate(x,y);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}