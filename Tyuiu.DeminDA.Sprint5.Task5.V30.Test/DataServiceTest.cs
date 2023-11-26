using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DeminDA.Sprint5.Task5.V30.Lib;
using System.IO;
namespace Tyuiu.DeminDA.Sprint5.Task5.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V30.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
