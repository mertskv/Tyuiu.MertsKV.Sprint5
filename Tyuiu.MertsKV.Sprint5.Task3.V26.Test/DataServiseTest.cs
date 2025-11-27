using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.MertsKV.Sprint5.Task3.V26.Lib;
namespace Tyuiu.MertsKV.Sprint5.Task3.V26.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\kmert\source\repos\Tyuiu.MertsKV.Sprint5\Tyuiu.MertsKV.Sprint5.Task3.V26\bin\Debug\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = false;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
