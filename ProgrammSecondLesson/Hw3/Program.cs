using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Жирнов. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.");
            int sum = 0;
            int number = 0;
            Console.WriteLine("Для того, чтобы вычислить сумму всех нечётных положительных чисел задайте их. Для окончания ввода чисел введите 0");
            number = ProgrammSecondLesson.Program.SumNaturalOdd(ref sum);
            Console.WriteLine("Сумма всех нечётных положительных чисел: " + sum);
            ProgrammSecondLesson.Program.CloseProgrammKey();
        }

        #region Метод вычисления суммы нечётных положительных чисел
        /*private static int SumNaturalOdd(ref int sum)
        {
            int number;
            do
            {
                Console.WriteLine("Введите число: ");
                number = Convert.ToInt32(Console.ReadLine());
                if ((number % 2) == 1) sum = sum + number;
            }
            while (number != 0);
            return number;
        }*/
        #endregion
    }
}
