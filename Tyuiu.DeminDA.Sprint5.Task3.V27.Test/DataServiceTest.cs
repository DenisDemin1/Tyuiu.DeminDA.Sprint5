using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DeminDA.Sprint5.Task3.V27.Lib;
using System.IO;

namespace Tyuiu.DeminDA.Sprint5.Task3.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\deti2\source\repos\Tyuiu.DeminDA.Sprint5\Tyuiu.DeminDA.Sprint5.Task3.V27\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(true, fileExist);
        }
    }
}
