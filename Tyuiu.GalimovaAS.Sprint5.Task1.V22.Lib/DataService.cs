﻿using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GalimovaAS.Sprint5.Task1.V22.Lib
{
    public class DataService : ISprint5Task1V16
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
                double zero = 2 * x - 0.5;

                if (zero == 0)
                {
                    return Convert.ToString(0);
                }
                else
                {
                    y = Math.Round(Math.Sin(x) + (2 * x) / 3 - Math.Cos(x) * 4 * x, 2);
                }
                strY = Convert.ToString(y);

                if (x != stopValue)
                {
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
