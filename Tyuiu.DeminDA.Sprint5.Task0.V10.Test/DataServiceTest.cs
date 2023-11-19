using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.DeminDA.Sprint5.Task0.V10.Lib;

namespace Tyuiu.DeminDA.Sprint5.Task0.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSaveToFileTextData()
        {   
            string path = @"C:\Users\deti2\source\repos\Tyuiu.DeminDA.Sprint5\Tyuiu.DeminDA.Sprint5.Task0.V10\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(true, fileExist);
        }
    }
}
