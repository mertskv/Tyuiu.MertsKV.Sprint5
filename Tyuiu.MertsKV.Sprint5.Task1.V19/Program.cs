using Tyuiu.MertsKV.Sprint5.Task1.V19.Lib;
namespace Tyuiu.MertsKV.Sprint5.Task1.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataServise ds = new DataServise();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("startValue = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            

            string res = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");

            
            Console.ReadKey();
        }
    }
}
