using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hw5
{
    static class DuoCount
    {
        public static int[] ReadArray(string str)
        {
            try
            {
                StreamReader ra = new StreamReader(str);
                int n = int.Parse(ra.ReadLine());
                int[] txtarr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    txtarr[i] = int.Parse(ra.ReadLine());
                    //Console.WriteLine(a);
                }
                ra.Close();
                return txtarr;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не найден");
            }
            return null;
        }


    }
    #region Условия задачи
    /*Жирнов
     * а) Реализовать библиотеку с классом для работы с двумерным массивом.Реализовать конструктор, заполняющий массив случайными числами.
     * Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, 
     * свойство, возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, метод, 
     * возвращающий номер максимального элемента массива(через параметры, используя модификатор ref или out).
      б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
      в) Обработать возможные исключительные ситуации при работе с файлами.*/
    #endregion
    class MyArrayTwoDim
    {
        int[,] a;

        public MyArrayTwoDim(int n, int el)
        {
            a = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    a[i, j] = el;
        }
        public MyArrayTwoDim(int n, int min, int max)
        {
            a = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    a[i, j] = rnd.Next(min, max);
        }
        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                        sum = sum + a[i, j];
                return sum;
            }
        }
        public int Sum2(int t)
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    if (a[i, j] > t) sum = sum + a[i, j];
            return sum;
        }
        public int Min
        {
            get
            {
                int min = a[0, 0];
                // Находим минимальный элемент
                // В двухмерном массиве для получения размерности нужно использовать
                // метод GetLength, а в скобках указывать измерение
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                        if (a[i, j] < min) min = a[i, j];
                return min;
            }
        }
        public void WriteArray()
        {
            StreamWriter write = new StreamWriter("..\\..\\write.txt", true);
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    write.Write(a[i, j] + " ");
                }
                write.WriteLine();
            }
            write.Close();
            Console.WriteLine("Готово!");
        }
        public int Max
        {
            get
            {
                int max = a[0, 0];
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                        if (a[i, j] > max) max = a[i, j];
                return max;
            }
        }
        public void Maxi(out int countMaxi, out int countMaxj)
        {
            countMaxi = 1;
            countMaxj = 1;
            int max = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    if (a[i, j] > max) { max = a[i, j]; countMaxi = i + 1; countMaxj = j + 1; }

        }
        // Свойство - подсчет количества положительных
        public int CountPositive
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                        if (a[i, j] > 0) count++;
                return count;
            }
        }
        // Свойство - подсчет среднего арифметического
        public double Average
        {
            get
            {
                double sum = 0;
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                        sum += a[i, j];
                return sum / a.GetLength(0) / a.GetLength(1);
            }

        }
        // Метод, который возвращает массив в виде строки
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    s += a[i, j] + " ";
                s += "\n"; // Переход на новую строчку

            }
            return s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int t = 5;
            MyArrayTwoDim a = new MyArrayTwoDim(2, 0, 10);
            Console.WriteLine(a.ToString());
            Console.WriteLine("Сумма элементов: " + a.Sum);
            Console.WriteLine("Сумма элементов больше 5: " + a.Sum2(t));
            Console.WriteLine("\nМаксимальный элемент:" + a.Max);
            Console.WriteLine("Минимальный элемент:" + a.Min);
            Console.WriteLine("Среднее значение элементов:" + a.Average);
            int i, j;
            a.Maxi(out i, out j);
            Console.WriteLine($"Наибольший элемент находится в строке {i} и столбце {j}");


            string s = null;
            string file = "..\\..\\data.txt";
            if (DuoCount.ReadArray(file) != null)
            {
                foreach (var item in DuoCount.ReadArray(file))
                {
                    s += " " + item;
                }
            }
            Console.WriteLine(s);

            a.WriteArray();
            Console.ReadKey();
        }
    }
}
