using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using System.IO;
using Tyuiu.MertsKV.Sprint5.Task4.V10.Lib;
namespace Tyuiu.MertsKV.Sprint5.Task4.V10.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V10.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
