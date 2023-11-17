using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;


using Tyuiu.ShananinaVV.Sprint5.Task2.V17.Lib;

namespace Tyuiu.ShananinaVV.Sprint5.Task2.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\valer\source\repos\Tyuiu.ShananinaVV.Sprint5\Tyuiu.ShananinaVV.Sprint5.Task2.V17\bin\Debug\OutPutFileTask2.csv";


            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
