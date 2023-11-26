using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DeminDA.Sprint5.Task6.V17.Lib;
using System.IO;

namespace Tyuiu.DeminDA.Sprint5.Task6.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");


            string path = @"C:\DataSprint5\InPutDataFileTask6V17.txt";


            Console.WriteLine("Данные находяться в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Количество пробелов, идущих подряд больше одного = "+ res);
            Console.ReadKey();
        }
    }
}
