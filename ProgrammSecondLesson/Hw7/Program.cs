using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw7
{
    class Program
    {
        #region Рекурсивный метод вывода чисел от a до b
        /*static void Numbers(int a, int b)
        {
            if (b > a)
            {
                Console.WriteLine($"Число {a}");
                Numbers(a + 1, b);
            }
        }*/
        #endregion
        #region Рекурсивный метод подсчёта суммы чисел от a до b
       /* static int Su(int a, int b)
        {
            {
                // Базовый случай
                if (b == a)
                {
                    return b;
                }
                else return Su(a, b - 1) + b;
            }
        }*/
        #endregion


        static void Main(string[] args)
        {
            #region Программа для вывода чисел от a до b и подсчёта их суммы
            Console.WriteLine("Жирнов. a) Разработать рекурсивный метод, который выводит на экран числа от a строго до b(a<b). б) * Разработать рекурсивный метод, который считает сумму чисел от a до b.");
            Console.WriteLine("Введите число a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Числа от а строго до b: ");
            ProgrammSecondLesson.Program.Numbers(a,b);
            Console.WriteLine($"Сумма чисел от a до b включительно {ProgrammSecondLesson.Program.Su(a, b)}");
            ProgrammSecondLesson.Program.CloseProgrammKey();
            #endregion
        }


    }
}
