﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SmirnovMN.Sprint5.Task3.V2.Lib;
using System.IO;
namespace Tyuiu.SmirnovMN.Sprint5.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\mishasmirnov\source\repos\Tyuiu.SmirnovMN.Sprint5\Tyuiu.SmirnovMN.Sprint5.Task3.V2\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
