using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Жирнов. Написать метод, возвращающий минимальное из трёх чисел.");
            ProgrammSecondLesson.Program.Min3();
            ProgrammSecondLesson.Program.CloseProgrammKey();
        }

        #region Метод поиска минимального из трёх чисел
        /*private static void Min3()
        {
            Console.WriteLine("Для того, чтобы найти наименьшее из трёх чисел:");
            Console.WriteLine("Введите первое число ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите третье число ");
            double number3 = Convert.ToDouble(Console.ReadLine());
            if ((number1 < number2) && (number2 < number3)) Console.WriteLine($"Наименьшее число: " + number1);
            else if (number2 < number3) Console.WriteLine($"Наименьшее число: " + number2);
            else Console.WriteLine($"Наименьшее число: " + number3);
        }*/
        #endregion
    }
}
