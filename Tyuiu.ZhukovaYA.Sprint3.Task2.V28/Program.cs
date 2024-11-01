using Tyuiu.ZhukovaYA.Sprint3.Task2.V28.Lib;
namespace Tyuiu.ZhukovaYA.Sprint3.Task2.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Жукова Яна Андреевна | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Оператор цикла do-while                                                 *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Жукова Яна Андреевна | ИИПБ-24-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Написать программу используя цикл do...while, которая вычисляет произведе*");
            Console.WriteLine("*ение ряда по формуле.                                                    *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите startValue:");
            int x = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Введите stopValue:");
            int y = int.Parse(Console.ReadLine()!);
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine(ds.GetMultiplySeries(x, y));
            Console.ReadKey();
        }
    }
}