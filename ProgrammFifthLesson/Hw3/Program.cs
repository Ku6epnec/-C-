using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Условия задачи
            /*Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
            Например:
            badc являются перестановкой abcd.*/
            #endregion
            
            Console.WriteLine("Для сравнения, является ли первая строка перестановкой второй, введите первую строку: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Введите вторую строку: ");
            string str2 = Console.ReadLine();
            for (int i=str1.Length-1; i>=0; i--)
            {
                for (int j = str2.Length-1; j >= 0; j--)
                {
                    if (str1[i] == str2[j])
                    { str1 = str1.Remove(i, 1); str2 = str2.Remove(j, 1);  break; }
                }    
            }
            if ((str2 == "")&&(str1 =="")) Console.WriteLine("Первая и вторая строка являются перестановкой друг друга!");
            else Console.WriteLine("Эти строки не являются друг другу перестановкой!");
            Console.ReadKey();
        }

    }
}
