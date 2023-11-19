using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SmirnovMN.Sprint5.Task1.V16.Lib;

namespace Tyuiu.SmirnovMN.Sprint5.Task1.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Смирнов М.Н. | ИИПБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант 16                                                              *");
            Console.WriteLine("* Выполнил: Cмирнов Михаил Николаевич | ИИПБ-23-2                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция, F(x)=(2x - 3)/(cos(x) + x) + 5 (произвести табулирование) *");
            Console.WriteLine("* f(x) на заданном диапозоне [-5;5] с шагом 1. Произвести проверку деления*");
            Console.WriteLine("* на ноль. При делении на ноль вернуть значение 0. результат сохранить в  *");
            Console.WriteLine("* текстовый файл OutPutFileTask1.txt и вывести на консоль в таблицу.      *");
            Console.WriteLine("* Значения округлить до двух знаков после запятой.                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Файл " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
