using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DeminDA.Sprint5.Task6.V17.Lib
{
    public class DataService : ISprint5Task6V17
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            int consecutiveSpaces = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    foreach (char c in line)
                    {
                        if (c == ' ')
                        {
                            consecutiveSpaces++;
                        }
                        else
                        {
                            if (consecutiveSpaces > 1)
                            {
                                count++;
                            }
                            consecutiveSpaces = 0;

                        }
                    }
                }
            }
            return count;
        }
    }
}


