using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.DeminDA.Sprint5.Task4.V20.Lib
{
    public class DataService : ISprint5Task4V20
    {
        public double LoadFromDataFile(string path)
        {
            string strx = File.ReadAllText(path);
            double x  = Convert.ToDouble(strx);
            double res = Math.Round(Math.Pow((Math.Pow(x,2))/Math.Sin(x),3),3);
            return res;
        }
    }
}
