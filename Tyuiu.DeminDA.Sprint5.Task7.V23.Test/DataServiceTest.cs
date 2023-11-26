using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DeminDA.Sprint5.Task7.V23.Lib;
using System.IO;
namespace Tyuiu.DeminDA.Sprint5.Task7.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\deti2\source\repos\Tyuiu.DeminDA.Sprint5\Tyuiu.DeminDA.Sprint5.Task7.V23\bin\Debug\OutPutDataFileTask7V23.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
