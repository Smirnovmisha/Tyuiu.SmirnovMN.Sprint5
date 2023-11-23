using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SmirnovMN.Sprint5.Task4.V18.Lib;

namespace Tyuiu.SmirnovMN.Sprint5.Task4.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Смирнов М.Н | ИИПБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема:    Чтение данных из текстового файла                              *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнила: Смирнов Михаил Николаевич | ИИПБ-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дан файл С:/DataSprint5/InPutDataFileTask4V0.txt. Создать папку в ручную*");
            Console.WriteLine("* С:/DataSprint5/ и скопировать в неё файл) в котором есть вещественное   *");
            Console.WriteLine("*  значение из файла и подставить вместо Х в формуле Y = 4.26x/sin(x)     *");
            Console.WriteLine("*Вычислить значение (округлить до 3 знаков), вернуть  результат на консоль*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = $@"{Directory.GetCurrentDirectory()}\InPutFileTask4.txt";
            Console.WriteLine("Данные находятся в файле:  " + path);



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
