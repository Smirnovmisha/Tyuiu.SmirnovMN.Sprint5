using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SmirnovMN.Sprint5.Task1.V16.Lib
{
    public class DataService : ISprint5Task1V16
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists) File.Delete(path);
            double y;
            string stry;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Cos(x) + x == 0)
                {
                    y = 0; stry = Convert.ToString(y);
                }
                else
                {
                    y = Math.Sin(x) + (2 * x / 3) - Math.Cos(x) * 4 * x ;
                    y = Math.Round(y, 2);
                    stry = Convert.ToString(y);
                }
                if (x != stopValue) File.AppendAllText(path, stry + Environment.NewLine);
                else File.AppendAllText(path, stry);
            }
            return path;
        }
    }
}
