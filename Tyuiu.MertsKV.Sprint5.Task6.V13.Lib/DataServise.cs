using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.MertsKV.Sprint5.Task6.V13.Lib
{
    public class DataServise : ISprint5Task6V13
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            int index = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string lowerStr = line.ToLower();
                    while ((index = lowerStr.IndexOf("сс", index)) != -1)
                    {
                        count++;
                        index += 2;
                    }
                }
            }
            return count;
        }
    }
}  
