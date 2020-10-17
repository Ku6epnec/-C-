using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NameSpaceLesson1 //Это задание 6
{
    public class Program
    {
        static void Main(string[] args)
        {
            # region Считывание данных пользователя
            string surname, name, age, town;
            int height, weight;
            ReadUserData(out surname, out name, out age, out height, out weight, out town);
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
            #region Вывод массы тела
            Console.WriteLine($"Индекс массы тела в кг/м^2: {weight * 10000 / (height * height)}.");
            #endregion
            #region Ввод координат 2 точек для подсчёта расстояния
            Console.WriteLine("Для подсчёта расстояния между 2 точками введи их координаты:  ");
            double x1, y1, x2, y2;
            ReadingTwoCoordinats(out x1, out y1, out x2, out y2);
            #endregion
            #region Вывод расстояния между 2 точками
            CalculatingDistance(x1, y1, x2, y2);
            #endregion
            #region Обмен значениями двух переменных с использованием третьей
            ChangeTwoVariables();
            #endregion
            #region Обмен числовых переменных без третьей переменной:
            int a = 1;
            int b = 2;
            a = a + b;
            b = a - b;
            a = a - b;
            #endregion
            #region Вывод фамилии, имени и города в разных частях экрана
            Console.WriteLine($"Фамилия: {surname}. Имя: {name}. Город проживания: {town}.");
            Console.WriteLine($"Для продолжения нажмите любую клавишу");
            Console.ReadKey();
            Console.Clear();
            var line = "Фамилия: " + surname + ". Имя: " + name + ". Город проживания: " + town + ".";
            WriteCenter(surname, name, town, line);
            #endregion
            #region Подпись
            EndProgramm();
            #endregion
            CloseProgrammKey();
        }
        #region Метод окончания программы
        public static void EndProgramm()
        {
            Console.WriteLine("(c) Автор программы Жирнов Олег. 2020 г");
        }
        #endregion
        #region Метод вывода в центре экрана
        public static void WriteCenter(string surname, string name, string town, string line)
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - line.Length / 2, Console.WindowHeight / 2);
            Console.WriteLine($"Фамилия: {surname}. Имя: {name}. Город проживания: {town}.");
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
        #region Метод обмена значениями двух переменных с использованием третьей
        public static void ChangeTwoVariables()
        {
            Console.WriteLine("Обмен значениями двух переменных.");
            Console.Write("Введите значение первой переменной: ");
            var variable1 = Console.ReadLine();
            Console.Write("Введите значение второй переменной: ");
            var variable2 = Console.ReadLine();
            var i = variable1;
            variable1 = variable2;
            variable2 = i;
            Console.WriteLine($"Первая переменная теперь: {variable1}.");
            Console.WriteLine($"Вторая переменная теперь: {variable2}.");
        }
        #endregion
        #region Метод считывания координат 2 точек
        public static void ReadingTwoCoordinats(out double x1, out double y1, out double x2, out double y2)
        {
            Console.Write("Введите значение по оси координат X для первой точки: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение по оси координат Y для первой точки: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение по оси координат X для второй точки: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение по оси координат Y для второй точки: ");
            y2 = Convert.ToDouble(Console.ReadLine());
        }
        #endregion
        #region Метод считывания данных пользователя для Анкеты
        public static void ReadUserData(out string surname, out string name, out string age, out int height, out int weight, out string town)
        {
            Console.Write("Введите фамилию: ");
            surname = Console.ReadLine();
            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.Write("Введите возраст: ");
            age = Console.ReadLine();
            Console.Write("Введите рост в сантиметрах: ");
            height = int.Parse(Console.ReadLine());
            Console.Write("Введите вес в килограммах: ");
            weight = int.Parse(Console.ReadLine());
            Console.Write("Введите город проживания: ");
            town = Console.ReadLine();        
        }
        #endregion
        #region Метод подсчёта расстояния между точками
        public static void CalculatingDistance(double x1, double y1, double x2, double y2)
        {
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Расстояние между заданными точками: {r:f2}.");
        }
        #endregion

    }
}
