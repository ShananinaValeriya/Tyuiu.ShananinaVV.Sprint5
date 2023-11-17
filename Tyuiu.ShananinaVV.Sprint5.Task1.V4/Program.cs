using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ShananinaVV.Sprint5.Task1.V4.Lib;

namespace Tyuiu.ShananinaVV.Sprint5.Task1.V4
{
    class Program
    {
        static void Main(string[] args)
        {

            int startValue = -5;
            int stopValue = 5;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Шананина В. В. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнила: Шананина Валерия Викторовна | ИСТНб-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция: F(x) = cos(x) / (x+1) - cos(x) * 1,3 + 3х                 *");
            Console.WriteLine("* Произвести табулирование f(x) на заданном диапазоне [-5;5] с шагом 1.   *");
            Console.WriteLine("* Произвести проверку деления на ноль. При делении на ноль вернуть        *");
            Console.WriteLine("* значение 0. Результат сохранить в текстовый файл OutPutFileTask1.txt    *");
            Console.WriteLine("* и вывести на консоль в таблицу. Округлить до двух знаков после запятой. *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
