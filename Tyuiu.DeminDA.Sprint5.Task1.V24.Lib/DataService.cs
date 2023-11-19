using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.DeminDA.Sprint5.Task1.V24.Lib
{
    public class DataService : ISprint5Task1V24
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            if (fileExist)
            {
                File.Delete(path);
            }

            double y;
            string strY;
            for (int x = startValue; x <= stopValue; x++)
            {
                double det = 4 * x - 0.5;
                if (det == 0)
                {
                    return Convert.ToString(0);
                }
                else
                {
                    y = Math.Round(3* Math.Cos(x) / (4 * x - 0.5) + Math.Sin(x) - 5 * x - 2,2);
                }
                strY = Convert.ToString(y);

                if (x != stopValue)
                {
                    File.AppendAllText(path, strY+Environment.NewLine);
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
