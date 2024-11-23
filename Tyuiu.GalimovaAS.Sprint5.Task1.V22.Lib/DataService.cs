using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GalimovaAS.Sprint5.Task1.V22.Lib
{
    public class DataService : ISprint5Task1V22
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.GetTempFileName();

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double y;
            string strY;
            for (int x = startValue; x <= stopValue; x++)

            {

                y = Math.Round(Math.Sin(x) + ((Math.Cos(x) + 1) / (2 - x)) + 2 * x, 2);
                strY = Convert.ToString(y);

                if (x != stopValue)
                {
                    if (x - 2 != 0)
                    {
                        y = Math.Round(Math.Sin(x) + ((Math.Cos(x) + 1) / (2 - x)) + 2 * x, 2);
                        strY = Convert.ToString(y);
                    }
                    else
                    {
                        y = 0;
                        strY = Convert.ToString(y);
                    }
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }
            return path;

        }
    }
}
