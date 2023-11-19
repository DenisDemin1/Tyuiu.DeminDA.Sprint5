using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.DeminDA.Sprint5.Task1.V24.Lib;

namespace Tyuiu.DeminDA.Sprint5.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSaveToFileTextData()
        {
            string path = @"C:\Users\deti2\source\repos\Tyuiu.DeminDA.Sprint5\Tyuiu.DeminDA.Sprint5.Task1.V24\bin\Debug\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(true, fileExist);
        }
    }
}
