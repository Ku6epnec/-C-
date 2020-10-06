using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
/**Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
 * Написать программу, демонстрирующую все разработанные элементы класса.
* Добавить свойства типа int для доступа к числителю и знаменателю;
* Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
*** Добавить упрощение дробей.
*НЕ ДОДЕЛАНО!
*/
class Rational
{
    int num;
    int denom;
    public Rational()
    {
        num = 1;
        denom = 1;
    }
    public Rational(int _num, int denom)
    {
        num = _num;
        this.denom = denom;
        try
        {
            int num = 100 / denom;
        }
        catch 
        {
            Console.WriteLine($"Знаменатель не может быть равен 0");
        }
    }

    public Rational Plus(Rational x2)
    {
        Rational x3 = new Rational();
        x3.num = num * x2.denom + x2.num * denom;
        x3.denom = x2.denom * denom;
        return x3;
    }
    public Rational Minus(Rational x2)
    {
        Rational x3 = new Rational();
        x3.num = num * x2.denom - x2.num * denom;
        x3.denom = x2.denom * denom;
        return x3;
    }
    public Rational Multi(Rational x2)
    {
        Rational x3 = new Rational();
        x3.num = num * x2.num;
        x3.denom = denom * x2.denom;
        return x3;
    }
    public Rational Split(Rational x2)
    {
        Rational x3 = new Rational();
        x3.num = num * x2.denom;
        x3.denom = x2.num * denom;
        return x3;
    }

    public override string ToString()
    {
        return num + "/" + denom;
    }
    public int Num
    {
        get
        {
            return num;
        }
    }
    public int Denom
    {
        get
        {
            return denom;
        }
    }
    public void ToRat(out int Num, out int Denom)
    {
        Console.WriteLine("Введите десятичную дробь для преобразования: ");
        double number = Convert.ToDouble(Console.ReadLine());
        Num = Convert.ToInt32(number * 10);
        Denom = 10;
    }

    public void Simple()
    {
        int i = num;
        while ((num % i != 0) || (denom % i != 0))
        {
            i--;
        }
        num = num / i;
        denom = denom / i;
    }
}
namespace Hw3
{
    class Program
    {
        static void Main(string[] args)
        {

            Rational rat1 = new Rational(10,15);
            Rational rat2 = new Rational(1,2);

            Console.WriteLine(rat1.ToString());
            Console.WriteLine(rat2.ToString());
            Console.WriteLine("Сокращаем первую дробь:");
            rat1.Simple();
            Console.WriteLine(rat1.Num);
            Console.WriteLine(rat1.Denom);
            Console.WriteLine();
            Console.WriteLine(rat1.Num);
            Console.WriteLine(rat1.Denom);
            Console.WriteLine(rat2.Num);
            Console.WriteLine(rat2.Denom);
            Console.WriteLine();
            Console.WriteLine(rat1.Plus(rat2));
            Console.WriteLine(rat1.Minus(rat2));
            Console.WriteLine(rat1.Multi(rat2));
            Console.WriteLine(rat1.Split(rat2));
            Console.WriteLine();
            int Num, Denom;
            rat1.ToRat(out Num,out Denom);
            Console.WriteLine($"Числитель: {Num} Знаменатель: {Denom}");
            Console.WriteLine();
            Rational rat3 = new Rational(1, 0);
            Console.ReadKey();
        }
    }
}
