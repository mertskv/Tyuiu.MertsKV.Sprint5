using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MertsKV.Sprint5.Task0.V19.Lib;
using System.IO;
namespace Tyuiu.MertsKV.Sprint5.Task0.V19.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\kmert\source\repos\Tyuiu.MertsKV.Sprint5\Tyuiu.MertsKV.Sprint5.Task0.V19\bin\Debug\net8.0";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists; //Проверка сущ-ет ли файл
            bool wait = false;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
