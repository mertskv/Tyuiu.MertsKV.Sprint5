using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MertsKV.Sprint5.Task2.V18.Lib;
using System.IO;
namespace Tyuiu.MertsKV.Sprint5.Task2.V18.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\kmert\source\repos\Tyuiu.MertsKV.Sprint5\Tyuiu.MertsKV.Sprint5.Task2.V18\bin\Debug\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = false;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
