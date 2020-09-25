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
            # region Считывание данных пользователя
            /*string surname, name, age;
            int height, weight;*/
            Console.Write("Введите фамилию: ");
            var surname = Console.ReadLine();
            Console.Write("Введите имя: ");
            var name = Console.ReadLine();
            Console.Write("Введите возраст: ");
            var age = Console.ReadLine();
            Console.Write("Введите рост в сантиметрах: ");
            var height = int.Parse(Console.ReadLine());
            Console.Write("Введите вес в килограммах: ");
            var weight = int.Parse(Console.ReadLine());
            /*Console.Write("Введите город проживания: ");
            town = Console.ReadLine();
            NameSpaceLesson1.Program.ReadUserData(out surname, out name, out age, out height, out weight, out town);*/
            #endregion
            #region Конкатинация строк
            Console.WriteLine("Фамилия: " + surname + ". Имя: " + name + ". Возраст: " + age + ". Рост: " + height + ". Вес: " + weight + ".");
            #endregion
            #region Форматированный вывод
            Console.WriteLine("Фамилия: {0}. Имя: {1}. Возраст: {2}. Рост: {3}. Вес: {4}.", surname, name, age, height, weight);
            #endregion
            #region Интерполированный вывод
            Console.WriteLine($"Фамилия: {surname}. Имя: {name}. Возраст: {age}. Рост: {height}. Вес: {weight}.");
            #endregion
            NameSpaceLesson1.Program.EndProgramm();
            NameSpaceLesson1.Program.CloseProgrammKey();
        }
    }
}
