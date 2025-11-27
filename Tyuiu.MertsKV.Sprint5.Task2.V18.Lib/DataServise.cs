using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.MertsKV.Sprint5.Task2.V18.Lib
{
    public class DataServise : ISprint5Task2V18
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;

            if (fileExist)
            {
                File.Delete(path);
            }

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }

            }
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += matrix[i, j] + ";";
                    }
                    else
                    {
                        str += matrix[i, j];
                    }
                }

                if (i != rows - 1)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }
                str = "";
            }
            return path;
        }
    }
}
