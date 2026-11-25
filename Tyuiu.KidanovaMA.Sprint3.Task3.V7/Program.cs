using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KidanovaMA.Sprint3.Task3.V7.Lib;

namespace Tyuiu.KidanovaMA.Sprint3.Task3.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнила: Киданова Мария Александровна | АСОиУБ 26-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Используя цикл foreach заменить буквы g на цифру 4 в строке:            *");
            Console.WriteLine("* gft hggt ntg                                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "gft hggt ntg";
            char replaceable = 'g';
            char replacement = '4';

            Console.WriteLine("Исходная строна = " + value);
            Console.WriteLine("Исходный символ = " + replaceable);
            Console.WriteLine("Символ на который меняем = " + replacement);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.ReplaceCharOnNum(value, replaceable, replacement));

            Console.ReadKey();
        }
    }
}