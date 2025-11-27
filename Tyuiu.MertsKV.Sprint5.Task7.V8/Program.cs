using System.IO;
using Tyuiu.MertsKV.Sprint5.Task7.V8.Lib;
namespace Tyuiu.MertsKV.Sprint5.Task7.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataServise ds = new DataServise();

            string path = @"C:\DataSprint5\InPutDataFileTask7V8.txt";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
                                                                                  
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string pathSaveFile = ds.LoadDataAndSave(path);

            Console.WriteLine("Результат находится в файле: " + pathSaveFile);

            Console.ReadKey();
        }
    }
}
