using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammSecondLesson
{
    public class Program
    {
        //Библиотека методов к уроку 2
        #region Рекурсивный метод вывода чисел от a до b
        public static void Numbers(int a, int b)
            {
                if (b > a)
                {
                    Console.WriteLine($"Число {a}");
                    Numbers(a + 1, b);
                }
            }
            #endregion
        #region Рекурсивный метод подсчёта суммы чисел от a до b
         public static int Su(int a, int b)
            {
                {
                    // Базовый случай
                    if (b == a)
                    {
                        return b;
                    }
                    else return Su(a, b - 1) + b;
                }
            }
        #endregion
        #region Метод подсчёта рекомендаций по весу
        public static void recommedWeight(double weight, double height)
        {
            if ((weight * 10000 / (height * height)) < 18.5) Console.WriteLine($"Ваш индекс массы тела: {(weight * 10000 / (height * height)):f2}. Рекомендую кушать чаще. Вам стоит набрать {((18.5 * height * height / 10000 - weight)):f2} килограмм.");
            else if ((weight * 10000 / (height * height)) > 25) Console.WriteLine($"Ваш индекс массы тела: {(weight * 10000 / (height * height)):f2}. Рекомендую посидеть на диете. Вам стоит похудеть на {(-25 * height * height / 10000 + weight):f2} килограмм.");
            else Console.WriteLine($"Ваш индекс массы тела: {(weight * 10000 / (height * height)):f2}. Вам не нужно ничего менять, вы итак молодец! ");
        }
        #endregion
        #region Метод прохождения авторизации
        public static int Authorization(string login, string password, out string variant, int count, out bool success)
        {
            Console.WriteLine("Для того, чтобы пройти авторизацию введите ваши данные");
            do
            {
                success = true;
                Console.WriteLine("Введите логин: ");
                variant = Console.ReadLine();
                success = (success) && (variant == login);
                Console.WriteLine("Введите пароль: ");
                variant = Console.ReadLine();
                success = (success) && (variant == password);
                count--;
            }
            while ((!success) && (count != 0));
            if (success) Console.WriteLine("Авторизация пройдена успешно!");
            else Console.WriteLine("Вы не справились с прохождением авторизцаии, рекомендую попробовать себя в чём-то ином!");
            return count;
        }
        #endregion
        #region Метод вычисления суммы нечётных положительных чисел
        public static int SumNaturalOdd(ref int sum)
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
        }
        #endregion
        #region Метод вычисления колчичества цифр числа
        public static void CountNumber()
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
        }
        #endregion
        #region Метод поиска минимального из трёх чисел
        public static void Min3()
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
        }
        #endregion
        #region Метод закрытия программы по кнопке
        public static void CloseProgrammKey()
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - "Для выхода из программы нажмите любую клавишу".Length / 2, Console.WindowHeight / 2 + 1);
            Console.WriteLine($"Для выхода из программы нажмите любую клавишу");
            Console.ReadKey();
        }
        #endregion
        static void Main(string[] args)
        {
        }
    }
}
