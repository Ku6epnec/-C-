using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Условия задачи
            /*Жирнов
            Дан целочисленный  массив  из 20 элементов.  Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно. 
            Заполнить случайными числами.  Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. 
            В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 
             */
            #endregion
            int[] arrayRandom = new int[20];
            Random rnd = new Random();
            int count = 0;
            int n = 10000;
            arrayRandom[0] = rnd.Next(-n, n);
            Console.WriteLine(arrayRandom[0]);
            for (int i = 1; i < arrayRandom.Length; i++)
            {
                arrayRandom[i] = rnd.Next(-n, n);
                if ((arrayRandom[i-1]%3==0) ^ (arrayRandom[i]%3==0)) count++; 
                Console.WriteLine(arrayRandom[i]);
            }
            Console.WriteLine($"Количество пар элементов массива, в которых только одно число делится на 3: {count}");
            Console.ReadKey();

        }
    }
}
