using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GalimovaAS.Sprint5.Task4.V7.Lib
{
    public class DataService : ISprint5Task4V7
    {
        public double LoadFromDataFile(string path)
        {
           
            string content;
            using (StreamReader sr = new StreamReader(path))
            {
                content = sr.ReadToEnd().Trim();
            }

            double x;
            if (!double.TryParse(content, NumberStyles.Any, CultureInfo.InvariantCulture, out x))
            {
                content = content.Replace('.', ',');
            }

            double y = Math.Round(1 / Math.Cos(Convert.ToDouble(x)) + Math.Pow(Convert.ToDouble(x), 3), 3);

            return Math.Round(y, 3);
        }
    }
}
