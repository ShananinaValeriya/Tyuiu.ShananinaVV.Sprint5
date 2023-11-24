using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.ShananinaVV.Sprint5.Task4.V10.Lib;

namespace Tyuiu.ShananinaVV.Sprint5.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            //string path = @"C:\Users\valer\source\repos\Tyuiu.ShananinaVV.Sprint5\Tyuiu.ShananinaVV.Sprint5.Task4.V10\bin\Debug\InPutDataFileTask4V10.txt";

            string path = @"C:\DataSprint5\InPutDataFileTask4V10.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
