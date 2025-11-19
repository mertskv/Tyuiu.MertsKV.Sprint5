using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.MertsKV.Sprint5.Task0.V19.Lib
{
    public class DataServise : ISprint5Task0V19
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            double res = (2 * Math.Pow(x, 2) - 1) / Math.Sqrt(Math.Pow(x, 2) - 2);
            res = Math.Round(res, 3);
            File.WriteAllText(path, Convert.ToString(res));
            return path;
        }
    }
}
