using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ShananinaVV.Sprint5.Task7.V4.Lib;


namespace Tyuiu.ShananinaVV.Sprint5.Task7.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Шананина В. В. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнила: Шананина Валерия Викторовна | ИСТНб-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:/DataSprint5/InPutDataFileTask7V4.txt. Создать папку вручную *");
            Console.WriteLine("* С:/DataSprint5/ и скопировать в неё файл, в котором есть набор          *");
            Console.WriteLine("* символьных данных. Заменить все русские буквы на #. Полученный          *");
            Console.WriteLine("* результат сохранить в файл OutPutDataFileTask7V4.txt.                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask7V4.txt";
            //string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7.txt";
            string pathSaveFile = @"C:\DataSprint5\OutPutDataFileTask7V4.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Находится в файле: ");

            pathSaveFile = ds.LoadDataAndSave(path);

            Console.WriteLine(pathSaveFile);
            Console.ReadKey();
        }
    }
}
