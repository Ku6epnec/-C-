using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Жирнов. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.");
            string login = "root";
            string password = "GeekBrains";
            string variant;
            int count = 3;
            bool success;
            count = ProgrammSecondLesson.Program.Authorization(login, password, out variant, count, out success);
            Console.WriteLine($"Для выхода из программы нажмите любую клавишу");
            Console.ReadKey();
        }

        #region Метод прохождения авторизации
        /*private static int Authorization(string login, string password, out string variant, int count, out bool success)
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
        }*/
        #endregion
    }
}
