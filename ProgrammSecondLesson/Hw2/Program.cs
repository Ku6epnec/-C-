using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hw2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Жирнов. Написать метод подсчета количества цифр числа.");
            ProgrammSecondLesson.Program.CountNumber();
            ProgrammSecondLesson.Program.CloseProgrammKey();
        }

        #region Метод вычисления колчичества цифр числа
        /*
        private static void CountNumber()
        {
            Console.WriteLine("Для того, чтобы узнать количество цифр введите число:");
            int number = Convert.ToInt32(Console.ReadLine());
            int Count = 0;
            while (number != 0)
            {
                number = number / 10;
                Count++;
            }
            Console.WriteLine($"В заданном числе " + Count + " цифр.");
        }*/
        #endregion
    }
}
