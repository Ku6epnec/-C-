using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Условия задачи
            /*Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, 
              содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
            а) без использования регулярных выражений;
            б) **с использованием регулярных выражений.*/
            #endregion
            Console.WriteLine($"Введите логин: ");
            string str = Console.ReadLine();
            var i = 1;
            bool prof = ((str[0]>= 'a') && (str[0] <= 'z')) || ((str[0] >= 'A') && (str[0] <= 'Z'));
            while (prof && i < str.Length)
            {
                prof = prof && (Char.IsDigit(str[i])|| ((str[i] >= 'a') && (str[i] <= 'z')) || ((str[i] >= 'A') && (str[i] <= 'Z')));
                i++;
            }
            if (prof && (str.Length <= 10) && (str.Length >= 2))
                Console.WriteLine("Вы ввели допустимый логин!");
            else Console.WriteLine("Вы ввели плохой логин!");
            Console.WriteLine("--------------");

            string pattern = @"^([a-zA-Z])([a-zA-Z0-9]){1,9}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(str))Console.WriteLine("Вы ввели допустимый логин!");
            else Console.WriteLine("Вы ввели плохой логин!");

            Console.ReadKey();
        }
    }
}
