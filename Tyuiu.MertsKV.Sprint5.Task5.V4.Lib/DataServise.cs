using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.MertsKV.Sprint5.Task5.V4.Lib
{
    public class DataServise : ISprint5Task5V4
    {
        public double LoadFromDataFile(string path)
        {
            double res = 1;

            string allText = File.ReadAllText(path);
            string[] numbers = allText.Split(' ');

            foreach (string value in numbers)
            {
                string formattedNum = value.Replace('.', ',');
                double numb = Convert.ToDouble(formattedNum);

                if (formattedNum.Contains(','))
                {
                    res = res * numb;
                }
            }

            return Math.Round(res, 3);


        }
    }
}
