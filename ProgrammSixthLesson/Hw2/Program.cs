using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

#region Условия задачи
/*Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата. 
а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум. 
Использовать массив (или список) делегатов, в котором хранятся различные функции.
б) *Переделать функцию Load, чтобы она возвращала массив считанных значений. Пусть она возвращает минимум через параметр (с использованием модификатора out).*/
#endregion

namespace Hw2
{
    delegate double Func(double x);
    class Program
    {
        public static double F(double x)
        {
            return x * x - 50 * x + 10;
        }
        public static double Sin(double x)
        {
            return Math.Sin(x);
        }
        public static double Square(double x)
        {
            return x*x;
        }
        public static double Root(double x)
        {
            return Math.Sqrt(x);
        }
        public static void SaveFunc(Func f,  string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(f(x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }
        public static double[] Loading(string fileName, out double[] array)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            array = new double[fs.Length+1];
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
                array[i] = d;
            }
            bw.Close();
            fs.Close();
            return array;
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Выберите функцию для взаимодействия, введя 1, 2, 3 или 4: ");
            int choise = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите начало отрезка: ");
            int begin = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите конец отрезка: ");
            int end = int.Parse(Console.ReadLine());
            //SaveFunc("data.bin", -100, 100, 0.5);
            switch (choise)
            {
                case 1: SaveFunc(new Func(F), "data.bin", begin, end, 0.5); break;
                case 2: SaveFunc(new Func(Sin), "data.bin", begin, end, 0.5); break;
                case 3: SaveFunc(new Func(Square), "data.bin", begin, end, 0.5); break;
                case 4: SaveFunc(new Func(Root), "data.bin", begin, end, 0.5); break;
            }
            //SaveFunc(new Func(F), "data.bin", begin, end, 0.5);
            Console.WriteLine(Load("data.bin"));
            Console.WriteLine("-----*----*-------*-----");
            double[] myArray = Loading("data.bin", out double[] array);
            Console.WriteLine("Длинна массива минимумов с заданным шагом: " + myArray.Length);
            Console.WriteLine("-----*----*-------*-----");
            for (int i=0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            //Console.WriteLine(Loading("data.bin", out double[] array));
            Console.ReadKey();
        }
    }
}
