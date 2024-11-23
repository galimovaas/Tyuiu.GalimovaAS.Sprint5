using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GalimovaAS.Sprint5.Task0.V24.Lib
{
    public class DataService : ISprint5Task0V24
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask0.txt" });
            double res = (Math.Pow(x, 3) - 8) / (2 * Math.Pow(x, 2));
            res = Math.Round(res, 3);
            File.WriteAllText(path, Convert.ToString(res));
            return path;
        }
    }
}
