using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2
{
    class Program
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Жирнов. С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.");
                int sum = 0;
                int number = 0;
                Console.WriteLine("Для того, чтобы вычислить сумму всех нечётных положительных чисел задайте их. Для окончания ввода чисел введите 0");
                number = SumNaturalOddTryParse(ref sum);
                Console.WriteLine("Сумма всех нечётных положительных чисел: " + sum);
                Console.ReadKey();
            }

        #region Метод вычисления суммы нечётных положительных чисел
        private static int SumNaturalOdd(ref int sum)
            {
                int number;
                string s;
                do
                {
                    Console.WriteLine("Введите число: ");
                    s = Console.ReadLine();
                if (int.TryParse(s, out number))
                {
                    if ((number % 2) == 1) sum = sum + number;
                }
                else Console.WriteLine("Вы ввели чушь, нужно вводить целое число!");
                }
                while (s != "0");
                return number;
            }
        #endregion

        #region Метод вычисления суммы нечётных положительных чисел
        private static int SumNaturalOddTryParse(ref int sum)
        {
            int number;
            double prov;
            string s;
            do
            {
                Console.WriteLine("Введите число: ");
                prov = Convert.ToDouble(Console.ReadLine());
                prov = prov / 2;
                s = Convert.ToString(prov+0.5);
                if (int.TryParse(s, out number) && (number > 0)) sum = sum + number * 2-1;
                else if (prov < 0) Console.WriteLine("Вы ввели отрицательное число!");
                else if (int.TryParse(Convert.ToString(prov), out number))
                    Console.WriteLine("Вы ввели чётное число!");
                else Console.WriteLine("Вы ввели дробное число!");
            }
            while (prov != 0);
            return number;
        }
        #endregion
    }
}

