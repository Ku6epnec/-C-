using System;
using System.Collections.Generic;
using System.Linq;
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
    double num;
    double denom;
    public Rational()
    {
        num = 0;
        denom = 0;
    }
    public Rational(double _num, double denom)
    {             
        num = _num;
        this.denom = denom;
    }

    public Rational Plus(Rational x2)
    {
        Rational x3 = new Rational();
        x3.num = x2.num*denom + num*x2.denom;
        x3.denom = x2.denom*denom;
        return x3;
    }

    public string ToString()
    {
        return num + "/" + denom;
    }


}
namespace Hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Введите числитель: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель: ");
            int denom = Convert.ToInt32(Console.ReadLine());*/
            Rational rat1 = new Rational(1,1);
            Rational rat2 = new Rational(1, 1);
            Console.WriteLine(rat1.Plus(rat2));
            string result = ToString(rat1.Plus(rat2));
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
