using System.IO;
using Tyuiu.MertsKV.Sprint5.Task4.V10.Lib;
namespace Tyuiu.MertsKV.Sprint5.Task4.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataServise ds = new DataServise();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask4V10.txt";

            Console.WriteLine("Данные находятся в файле " + path);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
