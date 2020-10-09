using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1
{

     #region Структура для работы с комплексными числами
    struct Complex
    {
        public double im;
        public double re;
        //  в C# в структурах могут храниться также действия над данными
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        //  Пример вычитания двух комплексных чисел
        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        //  Пример произведения двух комплексных чисел
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public new string ToString => re + "+(" + im + "i)";
    }
    #endregion


    class Program
    {
        static void Main(string[] args)
        {
            #region Изменённая структура 
            Complex complex1;
            complex1.re = 1;
            complex1.im = 1;

            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;

            Complex result = complex1.Plus(complex2);
            Console.WriteLine(result.ToString);
            result = complex1.Minus(complex2);
            Console.WriteLine(result.ToString);
            result = complex1.Multi(complex2);
            Console.WriteLine(result.ToString);
            #endregion

            //Комплексное число будет записываться в формате x1+ix2
            double x1 = 1;
            double x2 = 1;
            double y1 = 2;
            double y2 = 2;
            double z1;
            double z2;
            string oper = "не ноль";
            while (oper != "0") 
            {
                Console.WriteLine("Введите требуемую операцию в формате '+', '-', '*', для завершения введите '0'");
                oper = Console.ReadLine();

                switch (oper)
                {
                    case "+":
                        ComplexClass.Plus(x1, x2, y1, y2, out z1, out z2);
                        Console.WriteLine(ComplexClass.ComplexForm(z1, z2));
                        break;
                    case "-":
                        ComplexClass.Minus(x1, x2, y1, y2, out z1, out z2);
                        Console.WriteLine(ComplexClass.ComplexForm(z1, z2));
                        break;
                    case "*":
                        ComplexClass.Multi(x1, x2, y1, y2, out z1, out z2);
                        Console.WriteLine(ComplexClass.ComplexForm(z1, z2));
                        break;
                }
            }
        }

        #region Класс
        class ComplexClass
        {
            public static void Plus(double x1, double x2, double y1, double y2, out double z1, out double z2)
            {
                z1 = x1 + y1;
                z2 = x2 + y2;
            }
            public static void Minus(double x1, double x2, double y1, double y2, out double z1, out double z2)
            {
                z1 = x1 - y1;
                z2 = x2 - y2;
            }
            public static void Multi(double x1, double x2, double y1, double y2, out double z1, out double z2)
            {
                z1 = x1 * y1 - x2 * y2;
                z2 = x2 * y1 + x1 * y2;
            }
            public static string ComplexForm(double z1, double z2)
            {
                return z1 + "+(" + z2 + ")i";
            }
        }
        #endregion
    }

}
