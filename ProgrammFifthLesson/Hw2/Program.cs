using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hw2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Условия задачи
            /*Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
            а) Вывести только те слова сообщения,  которые содержат не более n букв.
            б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
            в) Найти самое длинное слово сообщения.
            г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
            д) ***Создать метод, который производит частотный анализ текста. В качестве параметра в него передается массив слов и текст, 
            в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary.
            */
            #endregion
            Console.WriteLine("Введите русский текст: ");
            string text = Console.ReadLine();
            string pattern = @"\b[а-яА-ЯёЁ]{1,10}\b";
            Regex regex = new Regex(pattern);
            Console.WriteLine(regex.IsMatch(text));
            var res = regex.Matches(text);
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------");

            string pattern1 = @"[а-яА-ЯёЁ]{1,}[^а][ ]\b";
            Regex regex1 = new Regex(pattern1);
            Console.WriteLine(regex1.IsMatch(text));
            var res1 = regex1.Matches(text);
            foreach (var item in res1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*********");

            string[] ss = text.Split(new char[] { ' ' });
            int max = ss[0].Length;
            string ssMax = ss[0];
            for (int i=1; i<ss.Length; i++)
            {
                if (max < ss[i].Length) { max = ss[i].Length; ssMax = ss[i]; }
            }
            Console.WriteLine(ssMax);
            Console.ReadKey();

        }
    }
}
