﻿using Tyuiu.GalimovaAS.Sprint5.Task4.V7.Lib;
namespace Tyuiu.GalimovaAS.Sprint5.Task4.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Галимова А.С. | АСОиУБ-24-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                    *");
            Console.WriteLine("* Чтение данных из текстового файла                                            *");
            Console.WriteLine("* Задание #4                                                                   *");
            Console.WriteLine("* Вариант #7                                                                   *");
            Console.WriteLine("* Выполнил: Галимова А.С. | АСОиУБ-24-1                                        *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дан файл                                                                     *");
            Console.WriteLine("* Прочитать значение из файла и подставить вместо Х в формул                   *");
            Console.WriteLine("* y = 1 / cos(x) + x^3                                                         *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            string path = @"C:\Users\alina\source\repos\Tyuiu.GalimovaAS.Sprint5\DataSprint5\InPutDataFileTask4V7.txt";

            Console.WriteLine("Данные находятся в файле: " + path);


            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
