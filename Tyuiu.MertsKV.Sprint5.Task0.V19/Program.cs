using Tyuiu.MertsKV.Sprint5.Task0.V19.Lib;
namespace Tyuiu.MertsKV.Sprint5.Task0.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataServise ds = new DataServise();
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 3;
            Console.WriteLine("x = " + x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл" + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
