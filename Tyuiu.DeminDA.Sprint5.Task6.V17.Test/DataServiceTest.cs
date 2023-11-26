using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using  System.IO;
using Tyuiu.DeminDA.Sprint5.Task6.V17.Lib;
namespace Tyuiu.DeminDA.Sprint5.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckLoadFromDataFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V17.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
