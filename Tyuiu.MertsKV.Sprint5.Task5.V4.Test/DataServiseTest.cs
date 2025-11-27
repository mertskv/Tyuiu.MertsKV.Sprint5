using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.MertsKV.Sprint5.Task5.V4.Lib;
namespace Tyuiu.MertsKV.Sprint5.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V4.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
