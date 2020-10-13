using doArray;
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
            #region Условия задачи
            /*Жирнов
            а) Дописать класс для работы с одномерным массивом.Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.
            Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива
            (старый массив, остается без изменений),  метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов. 
            б)**Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу библиотеки
            е) ***Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary< int,int>)
            */
            #endregion
            int x = 3;
            int[] freq = new int[10];
            doArray.MyArray a = new doArray.MyArray(10, 0, 5);
            int[] b = new int[10];
            Console.WriteLine(a.ToString());
            Console.WriteLine();
            Console.WriteLine();
            #region Dictionary
            Dictionary<int, int> d = a.ValuesCounters();
            foreach (KeyValuePair<int, int> keyValue in d)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            #endregion
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            b = a.Inverse();
            for (int i = 0; i < b.Length; i++)
                Console.Write(b[i] + " ");
            Console.WriteLine();
            freq = a.freq();
            
            for (int i = 0; i < freq.Length; i++)
                if (freq[i]!=0) Console.WriteLine("Значение " + i + " встречается " + freq[i] + " раз");
            Console.WriteLine();
            Console.WriteLine(a.Sum);
            Console.WriteLine(a.Max);
            Console.WriteLine(a.Min);
            Console.WriteLine(a.maxCount());
            Console.WriteLine(a.CountPositiv);
            a.Multi(x);
            Console.WriteLine(a.ToString());
            Console.ReadKey();


        }
    }
}
namespace doArray
{
    class MyArray
    {
        int[] a;
        //  Создание массива и заполнение его одним значением el  
        public MyArray(int n, int el)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = el;
        }
        //Создание массива определенного размера и заполняющий массив числами от начального значения с заданным шагом.
        public MyArray(int n, int min, int step)
        {
            a = new int[n];
            a[0] = min;
            for (int i = 1; i < n; i++)
                a[i] = a[i - 1] + step;
        }
        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 1; i < a.Length; i++)
                    sum = sum + a[i];
                return sum;
            }
        }
        # region Создание массива и заполнение его случайными числами от min до max
        /*public MyArray(int n, int min, int max)
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
        }*/
        #endregion
        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }
        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }
        public int CountPositiv
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > 0) count++;
                return count;
            }
        }
        public override string ToString()
        {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }
        public int[] Inverse()
        {
            int[] inver = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
                inver[i] = -a[i];
            return inver;
        }

        public void Multi(int x)
        {
            for (int i = 0; i < a.Length; i++)
                a[i] = a[i] * x;
        }

        public int maxCount()
        {
            int max = 0;
            int maxCount = 0;
            for (int i = 0; i < a.Length; i++)
                if (a[i] > max) { max = a[i]; maxCount = 0; }
                else if (a[i] == max) maxCount++;
            return maxCount;
        }
        public int[] freq()
        {
            // Создаем частотный массив от 0 до 99 
            int[] mass = new int[46];
            // Подсчитываем вхождение элементов 
            foreach (var v in a) mass[v]++;//Элемент массива a является номером в частотном массиве mass
            return mass;
        }
        public Dictionary<int, int> ValuesCounters()
        {
            Dictionary<int, int> valueCounters = new Dictionary<int, int>();
            int[] b = new int[a.Max() + 1];

            foreach (int v in a)
            {
                b[v]++;
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (!valueCounters.ContainsKey(a[i]))
                {
                    valueCounters.Add(a[i], b[a[i]]);
                }
            }
            return valueCounters;
        }
    }
}

    


