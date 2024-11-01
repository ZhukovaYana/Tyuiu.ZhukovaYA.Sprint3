using Tyuiu.ZhukovaYA.Sprint3.Task4.V14.Lib;
namespace Tyuiu.ZhukovaYA.Sprint3.Task4.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Жукова Яна Андреевна | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Использование операторов continue и break в циклах                      *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Жукова Яна Андреевна | ИИПБ-24-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*На отрезке, где x принимает значения от -5 до 5, вычислить значение функц*");
            Console.WriteLine("*ции y=cos(x)/sin(x). При х = 0 прервать цикл. Полученные значения суммиро*");
            Console.WriteLine("*овать.                                                                   *");

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


            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}