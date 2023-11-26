using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DeminDA.Sprint5.Task5.V30.Lib
{
    public class DataService : ISprint5Task5V30
    {
        public double LoadFromDataFile(string path)
        {
            double maxPrimeNumber = double.MinValue;

            using (StreamReader reader = new StreamReader(path))
            {
                // Перебираем все числа в файле
                while (!reader.EndOfStream)
                {
                    string numberStr = reader.ReadLine();

                    // Преобразуем строку в число
                    if (!double.TryParse(numberStr, out double number))
                    {
                        Console.WriteLine($"Некорректное число: {numberStr}");
                        continue;
                    }

                    // Проверяем, является ли число целым и положительным
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
            return maxPrimeNumber;
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
}

