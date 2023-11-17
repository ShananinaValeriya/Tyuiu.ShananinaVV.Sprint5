using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.ShananinaVV.Sprint5.Task0.V11.Lib;

namespace Tyuiu.ShananinaVV.Sprint5.Task0.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\valer\source\repos\Tyuiu.ShananinaVV.Sprint5\Tyuiu.ShananinaVV.Sprint5.Task0.V11\bin\Debug\OutPutFileTask0.txt";
            

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
