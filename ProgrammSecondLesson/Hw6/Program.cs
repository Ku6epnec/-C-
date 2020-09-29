using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Жирнов. Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. «Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени выполнения программы, используя структуру DateTime.");
            #region Вариант 1 цикл while
            DateTime date = DateTime.Now;
            Console.WriteLine("Вариант 1 цикл while");
            int count = 1;
            int countGood = 0;
            while (count <= 1000000000) 
            {
                if (count % ((count % 10) + ((count / 10) % 10) + ((count / 100) % 10) + ((count /1000) % 10) + ((count / 10000) % 10) + ((count / 100000) % 10)+ ((count / 1000000) % 10) + ((count / 10000000) % 10) + ((count / 100000000) % 10) + ((count / 1000000000) % 10)) == 0) countGood++;
                count++;
            }
            Console.WriteLine($"Всего хороших чисел: {countGood}");
            Console.WriteLine($"Затрачено времени на вычисления: {DateTime.Now - date}");
            #endregion

            #region Вариант 2 цикл for
            date = DateTime.Now;
            Console.WriteLine("Вариант 2 цикл for");
            count = 1;
            countGood = 0;
            for (count = 1; count<= 1000000000; count++)
            {
                if (count % ((count % 10) + ((count / 10) % 10) + ((count / 100) % 10) + ((count / 1000) % 10) + ((count / 10000) % 10) + ((count / 100000) % 10) + ((count / 1000000) % 10) + ((count / 10000000) % 10) + ((count / 100000000) % 10) + ((count / 1000000000) % 10)) == 0) countGood++;
            }
            Console.WriteLine($"Всего хороших чисел: {countGood}");
            Console.WriteLine($"Затрачено времени на вычисления: {DateTime.Now - date}");
            #endregion

            #region Вариант 3 цикл while в цикле for
            date = DateTime.Now;
            Console.WriteLine("Вариант 3 цикл while в цикле for с вариантом лёгкого исправления условий задачи");
            int goodCount = 0;
            int min = 1;
            int max = 1000000000;
            int sumOst;
            int ost;

            for (int counter = min; counter <= max; counter++)
            {
                sumOst = 0;
                ost = counter;
                while (ost != 0)
                {
                    sumOst += ost % 10;
                    ost /= 10;
                }
                if (counter % sumOst == 0) goodCount++;
            }
            Console.WriteLine($"Всего хороших чисел: {goodCount}");
            Console.WriteLine($"Затрачено времени на вычисления: {DateTime.Now - date}");
            #endregion

            ProgrammSecondLesson.Program.CloseProgrammKey();
        }
    }
}
