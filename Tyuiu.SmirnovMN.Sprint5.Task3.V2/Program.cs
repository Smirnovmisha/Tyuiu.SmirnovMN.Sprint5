using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SmirnovMN.Sprint5.Task3.V2.Lib;

namespace Tyuiu.SmirnovMN.Sprint5.Task3.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Смирнов М.Н | ИИПБ-23-2;";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема:    Потоковый метод записи данных в бинарный файл                  *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Смирнов Михаил Николаевич | ИИПБ-23-2                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дано выражение F(x) = e^x/x, вычислить его значение                     *");
            Console.WriteLine("* при x = 3, результат сохранить в бинарный файл OutPutFileTask3.bin и    *");
            Console.WriteLine("* вывести на консоль. Округлить до трёх знаков после запятой.             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("X =  " + x);



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("  Файл: " + res);
            Console.WriteLine("  Создан. ");
            Console.ReadKey();
        }
    }
}
