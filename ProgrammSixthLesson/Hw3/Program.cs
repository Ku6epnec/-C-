using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

#region Условия задачи
/*Переделать программу Пример использования коллекций для решения следующих задач:
а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
в) отсортировать список по возрасту студента;
г) *отсортировать список по курсу и возрасту студента;*/
#endregion

namespace Hw3
{
    class Student
    {
        public string Family { get; set; }
        public string Name { get; set; }

        public string University { get; set; }
        public string Faculty { get; set; }
        public string Special { get; set; }
        public int Age { get; set; }
        public int Course { get; set; }


    }

    class Program
    {
        static void Main(string[] args)
        {
            int numOfBachelors = 0;
            int numOfMasters = 0;
            int stud5 = 0;
            int stud6 = 0;
            int[] mass = new int[21];
            // Создадим необобщенный список
            ArrayList arrList = new ArrayList();
            ArrayList allList = new ArrayList();
            // Запомним время в начале обработки данных
            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader("..\\..\\students_1.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] student = sr.ReadLine().Split(',');
                    // Console.WriteLine("{0}", s[0], s[1], s[2], s[3], s[4]);
                    arrList.Add(student[0] + " " + student[1]);// Добавляем склееные имя и фамилию
                    allList.Add(
                        new Student
                        {
                            Family = student[0],
                            Name = student[1],
                            University = student[2],
                            Faculty = student[3],
                            Special = student[4],
                            Age = int.Parse(student[5]),
                            Course = int.Parse(student[6])
                        }); 
                    if (int.Parse(student[6]) < 5) numOfBachelors++; else numOfMasters++;
                    if (int.Parse(student[6]) == 5) stud5++; 
                    if (int.Parse(student[6]) == 6) stud6++;
                    mass[int.Parse(student[5])]++;
                }
                catch
                {
                }
            }
            sr.Close();
            arrList.Sort();
            Console.WriteLine("Всего студентов:{0}", arrList.Count);
            Console.WriteLine("Магистров:{0}", numOfMasters);
            Console.WriteLine("Бакалавров:{0}", numOfBachelors);
            Console.WriteLine("Магистров:{0}", numOfMasters);
            Console.WriteLine("Количество студентов 5 курса:{0}", stud5);
            Console.WriteLine("Количество студентов 6 курса:{0}", stud6);
            Console.WriteLine("-----*-----*----*----");
            for (int i = 18; i <= 20; i++)
            {
                Console.WriteLine(mass[i]);
            }
            Console.WriteLine("-----*-----*----*----");
            foreach (var v in arrList) Console.WriteLine(v);
            Console.WriteLine("-----*-----*----*----");
            var query = from Student student in allList
                        orderby student.Age
                        select ("Фамилия: " + student.Family + " Возраст: "+student.Age);
            foreach (var v in query)
                Console.WriteLine(v);
            Console.WriteLine("-----*-----*----*----");
            var querry = from Student student in allList
                        orderby student.Course, student.Age
                        select ("Фамилия: " + student.Family + ". Возраст: " + student.Age + ". Курс: " + student.Course + ".");
            foreach (var v in querry)
                Console.WriteLine(v);
            // Вычислим время обработки данных
            Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();

        }
    }
}
