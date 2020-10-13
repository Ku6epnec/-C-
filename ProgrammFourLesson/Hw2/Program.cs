using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hw2
{
    #region Условия задачи
    /*Жирнов
     Реализуйте задачу 1 в виде статического класса StaticClass;
        а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
        б) * Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
         в)** Добавьте обработку ситуации отсутствия файла на диске.
    */
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayRandom = new int[20];
            Random rnd = new Random();
            int count = 0;
            int n = 10000;
            for (int i = 0; i < arrayRandom.Length; i++)
            {
                arrayRandom[i] = rnd.Next(-n, n);
                Console.WriteLine(arrayRandom[i]);
            }
            count = StaticClass.Search3(arrayRandom, count);
            Console.ReadKey();

            try
            {
                TextToArray();
                for (int i = 0; i < TextToArray().Length; i++)
                    Console.WriteLine(TextToArray()[i]);
            }
            catch
            {
                Console.WriteLine("Такого файла нет");
            }
            Console.ReadKey();
        }

        public static int[] TextToArray()
        {

            // Создаем объект sr и связываем его с файлом data.txt.
            StreamReader sr = new StreamReader("..\\..\\data.txt");
            int numbers = int.Parse(sr.ReadLine());
            // Считаем количество чисел
            int[] arrayText = new int[numbers];
            for (int i = 0; i < numbers; i++)
            {
                arrayText[i] = int.Parse(sr.ReadLine());
            }
            // Освобождаем файл data.txt для использования другими программами.
            sr.Close();
            return arrayText;

        }
    }
    public static class StaticClass
    {
        public static int Search3(int[] arrayRandom, int count)
        {
            for (int i = 1; i < arrayRandom.Length; i++)
                if ((arrayRandom[i - 1] % 3 == 0) ^ (arrayRandom[i] % 3 == 0)) count++;
            Console.WriteLine($"Количество пар элементов массива, в которых только одно число делится на 3: {count}");
            return count;
        }
    }
}
