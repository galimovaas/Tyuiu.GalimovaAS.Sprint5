using Tyuiu.GalimovaAS.Sprint5.Task7.V15.Lib;
namespace Tyuiu.GalimovaAS.Sprint5.Task7.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Галимова А.С. | АСОиУБ-24-1";
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Спринт #5                                                                   *");
            Console.WriteLine("* Тема: Базовые навыки работы в с#                                            *");
            Console.WriteLine("* Задание #7                                                                  *");
            Console.WriteLine("* Вариант #23                                                                 *");
            Console.WriteLine("* Выполнила: Галимова А.С. | АСОиУБ-24-1                                      *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Условие                                                                     *");
            Console.WriteLine("* Прочитать значение из файла и подставить вместо Х в формуле . Вычислить     *");
            Console.WriteLine("* значение по формуле (Полученное значение округлить до трёх знаков после     *");
            Console.WriteLine("* запятой) и вернуть полученный результат на консоль                          *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Исходные данные:                                                            *");
            Console.WriteLine("*******************************************************************************");
            string path;
            Console.WriteLine("Введите путь к файлу:");

            path = Console.ReadLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.LoadDataAndSave(path);
            Console.WriteLine("Результат сохранен = " + res);
            Console.WriteLine("Создан!");
        }
    }
}
