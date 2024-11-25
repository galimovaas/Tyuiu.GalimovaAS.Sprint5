using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.GalimovaAS.Sprint5.Task0.V24.Lib
{
    public class DataService : ISprint5Task5V30
    {
        public string LoadFromDataFile(string path)
        {
           
            double maxPrimeNumber = double.MinValue;

            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    string lineReplace = line.Replace('.', ',');
                    string[] lineArray = lineReplace.Split(' ');
                }
                if (Math.Abs(number % 1) < double.Epsilon && number > 0)
                {
                    // Проверяем, является ли число простым
                    if (IsPrime((int)number))
                    {
                        // Обновляем максимальное простое число
                        if (number > maxPrimeNumber)
                        {
                            maxPrimeNumber = number;
                        }
                    }
                }
            }
        }
            return double ISprint5Task5V30.LoadFromDataFile(string path)
        {
            throw new NotImplementedException();
        }

        maxPrimeNumber;
    }

    private static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}


     
    

