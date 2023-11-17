using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.ShananinaVV.Sprint5.Task3.V18.Lib;


namespace Tyuiu.ShananinaVV.Sprint5.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\valer\source\repos\Tyuiu.ShananinaVV.Sprint5\Tyuiu.ShananinaVV.Sprint5.Task3.V18\bin\Debug\OutPutFileTask3.bin";


            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
