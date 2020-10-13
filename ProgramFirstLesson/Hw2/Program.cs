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
            #region Считывание данных пользователя
            /*string surname, name, age, town;
            int height, weight;
            NameSpaceLesson1.Program.ReadUserData(out surname, out name, out age, out height, out weight, out town);*/
            Console.Write("Введите рост в сантиметрах: ");
            var height = int.Parse(Console.ReadLine());
            Console.Write("Введите вес в килограммах: ");
            var weight = int.Parse(Console.ReadLine());
            #endregion
            #region Вывод массы тела
            Console.WriteLine($"Индекс массы тела в кг/м^2: {weight * 10000 / (height * height)}.");
            #endregion
            NameSpaceLesson1.Program.EndProgramm();
            NameSpaceLesson1.Program.CloseProgrammKey();
        }
    }
}
