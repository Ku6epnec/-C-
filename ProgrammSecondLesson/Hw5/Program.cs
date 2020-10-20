using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Программа вычисления рекомендаций по весу
            Console.WriteLine("Жирнов. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме. б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.");
            Console.WriteLine("Для того, чтобы узнать стоит ли посидеть на диете");
            Console.WriteLine("Введите вес в кг: ");
            double weight = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите рост в см: ");
            double height = int.Parse(Console.ReadLine());
            //double index = (weight * 10000 / (height * height));
            //double reccomendWeight= ((18.5 * height * height / 10000 - weight));
            ProgrammSecondLesson.Program.recommedWeight(weight, height);
            ProgrammSecondLesson.Program.CloseProgrammKey();
            #endregion
        }

        #region Метод подсчёта рекомендаций по весу
        private static void recommedWeight(double weight, double height)
        {
            if ((weight * 10000 / (height * height)) < 18.5) Console.WriteLine($"Ваш индекс массы тела: {(weight * 10000 / (height * height)):f2}. Рекомендую кушать чаще. Вам стоит набрать {((18.5 * height * height / 10000 - weight)):f2} килограмм");
            else if ((weight * 10000 / (height * height)) > 25) Console.WriteLine($"Ваш индекс массы тела: {(weight * 10000 / (height * height)):f2}. Рекомендую посидеть на диете. Вам стоит похудеть на {(-25 * height * height / 10000 + weight):f2} килограмм");
            else Console.WriteLine($"Ваш индекс массы тела: {(weight * 10000 / (height * height)):f2}. Вам не нужно ничего менять, вы итак молодец! ");
        }
        #endregion
    }
}
