using Tyuiu.GalimovaAS.Sprint5.Task1.V22.Lib;
namespace Tyuiu.GalimovaAS.Sprint5.Task1.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #5 | Выполнил: Галимова А.С | АСОиУБ-24-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #5                                                             *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл               *");
            Console.WriteLine("* Задание #1                                                            *");
            Console.WriteLine("* Варинат #22                                                           *");
            Console.WriteLine("* Выполнил:  Галимова А.С | АСОиУБ-24-1                                 *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИССХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("*************************************************************************");
            int startValue, stopValue;
            startValue = -5;
            stopValue = 5;

            Console.WriteLine("startValue = -5");
            Console.WriteLine("stopValue = 5");

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine("Файл: " + ds.SaveToFileTextData(startValue, stopValue));
            Console.WriteLine("Создан");
            Console.ReadKey();

        }
    }
}
