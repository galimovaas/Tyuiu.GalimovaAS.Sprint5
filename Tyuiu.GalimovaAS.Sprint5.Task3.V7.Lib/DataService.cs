using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GalimovaAS.Sprint5.Task3.V7.Lib
{
    public class DataService : ISprint5Task3V7
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Append)))
            {
                writer.Write(Math.Round((1.6 * Math.Pow(x, 3) - 2.1 * Math.Pow(x, 2) + 7 * x), 3));

            }

            return path;
        }
    }
}
