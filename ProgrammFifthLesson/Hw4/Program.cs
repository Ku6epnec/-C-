using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hw4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Условия задачи
            /*Задача ЕГЭ.
                На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы. 
                В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100, каждая из следующих N строк имеет следующий формат:
                <Фамилия> <Имя> <оценки>,
                где <Фамилия> — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не более чем из 15 символов, 
                <оценки> — через пробел три целых числа, соответствующие оценкам по пятибалльной системе. <Фамилия> и <Имя>, а также <Имя> и <оценки> 
                разделены одним пробелом. Пример входной строки:
                Иванов Петр 4 5 3
                Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников. 
                Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.
                */
            #endregion
            Console.WriteLine("Введите количество учеников: ");
            uint all = uint.Parse(Console.ReadLine());
            Console.WriteLine("Введите данные учеников в следующем формате: <Фамилия> <Имя> <Оценка1> <Оценка2> <Оценка3>");
            //StreamReader sr = new StreamReader("..\\..\\data.txt");
            string s = "";
            int min1 = 100;
            int min2 = 100;
            int min3 = 100;
            int count = 0;
            string[,] ss = new string[3, all];
            //uint all = uint.Parse(sr.ReadLine());
            for (int i = 0; i < all; i++)
            {
                s = Console.ReadLine();//sr.ReadLine();
                string[] sr = s.Split(new char[] { ' ' });
                sr[2] = Convert.ToString(int.Parse(sr[2]) + int.Parse(sr[3]) + int.Parse(sr[4]));
                for (int j = 0; j < 3; j++) ss[j, i] = sr[j];
            }
            for (int i = 0; i < all; i++)
            {
                if ((int.Parse(ss[2, i]) < min1) && (int.Parse(ss[2, i]) != min2) && (int.Parse(ss[2, i]) != min3)) min1 = int.Parse(ss[2, i]);
            }
            for (int i = 0; i < all; i++)
            {
                if ((int.Parse(ss[2, i]) < min2) && (int.Parse(ss[2, i]) != min1) && (int.Parse(ss[2, i]) != min3)) min2 = int.Parse(ss[2, i]);
                if (int.Parse(ss[2, i]) == min1) { count++; }
                        if (count == 2) break;
            }
            if (count != 2)
            {
                for (int i = 0; i < all; i++)
                {
                    if ((int.Parse(ss[2, i]) < min3) && (int.Parse(ss[2, i]) != min1) && (int.Parse(ss[2, i]) != min2)) min3 = int.Parse(ss[2, i]);
                    if ((int.Parse(ss[2, i]) == min1) || (int.Parse(ss[2, i]) == min2)) break;
                }
            }
                for (int i = 0; i < all; i++)
                {
                    if ((int.Parse(ss[2, i]) == min1) || (int.Parse(ss[2, i]) == min2) || (int.Parse(ss[2, i]) == min3))
                        Console.WriteLine(ss[0, i] + " " + ss[1, i]);
                }

            Console.ReadKey();

        }
    }
}
