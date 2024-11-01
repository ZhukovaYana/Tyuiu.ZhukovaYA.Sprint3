using Tyuiu.ZhukovaYA.Sprint3.Task5.V30.Lib;
namespace Tyuiu.ZhukovaYA.Sprint3.Task5.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Жукова Яна Андреевна | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Вложенные циклы                                                         *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Жукова Яна Андреевна | ИИПБ-24-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите x:");
            int x = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Введите startValue1:");
            int start1 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Введите stopValue1:");
            int stop1 = int.Parse(Console.ReadLine()!);
            DataService ds = new DataService();
            Console.WriteLine("Введите startValue2:");
            int start2 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Введите stopValue2:");
            int stop2 = int.Parse(Console.ReadLine()!);
            DataService ds = new DataService();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.GetSumSumSeries(x,start1,start2,stop1,stop2));
            Console.ReadKey();
        }
    }
}