using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw5
{
    class Program
    {
        static void Main(string[] args)
        {
            # region Считывание данных пользователя
            string surname, name, town;
            Console.Write("Введите фамилию: ");
            surname = Console.ReadLine();
            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.Write("Введите город проживания: ");
            town = Console.ReadLine();
            #endregion
            #region Вывод фамилии, имени и города в разных частях экрана
            Console.WriteLine($"Фамилия: {surname}. Имя: {name}. Город проживания: {town}.");
            Console.WriteLine($"Для вывода в центре экрана нажмите любую клавишу");
            Console.ReadKey();
            Console.Clear();
            var line = "Фамилия: " + surname + ". Имя: " + name + ". Город проживания: " + town + ".";
            NameSpaceLesson1.Program.WriteCenter(surname, name, town, line);
            #endregion
            NameSpaceLesson1.Program.CloseProgrammKey();
        }
    }
}
