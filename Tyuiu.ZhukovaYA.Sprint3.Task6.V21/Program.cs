using Tyuiu.ZhukovaYA.Sprint3.Task6.V21.Lib;
namespace Tyuiu.ZhukovaYA.Sprint3.Task6.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Жукова Яна Андреевна | ИИПБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Обработка целочисленной информации                                      *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Жукова Яна Андреевна | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Напишите программу, которая ищет среди целых чисел, принадлежащих числово*");
            Console.WriteLine("*ому отрезку [19, 30] сумму всех делителей.                               *");

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

            Console.WriteLine(ds.GetSumTheDivisors(x, y));
            Console.ReadKey();
        }
    }
}