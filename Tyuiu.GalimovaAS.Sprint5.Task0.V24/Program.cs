using Tyuiu.GalimovaAS.Sprint5.Task0.V24.Lib;
namespace Tyuiu.GalimovaAS.Sprint5.Task0.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Галимова А.С. | АСОиУБ - 24-1";
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* Спринт #5 *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл *");
            Console.WriteLine("* Задание #0 *");
            Console.WriteLine("* Вариант #24 *");
            Console.WriteLine("* Выполнила: Галимова А.С. | АСОиУБ - 24-1 *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: *");
            Console.WriteLine("* Дано выражение, вычислить его значенрие при х = 2, результат сохзранить в текстовый файл и *");
            Console.WriteLine("* вывести на консоль. Округлить до трех знаков после запятой *");
            Console.WriteLine("* *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: *");
            Console.WriteLine("****************************************************************************************************");

            Console.WriteLine(" x = " + x);

            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ: *");
            Console.WriteLine("****************************************************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
