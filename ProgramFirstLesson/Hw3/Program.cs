using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ввод координат 2 точек для подсчёта расстояния
            Console.WriteLine("Для подсчёта расстояния между 2 точками введи их координаты:  ");
            double x1, y1, x2, y2;
            NameSpaceLesson1.Program.ReadingTwoCoordinats(out x1, out y1, out x2, out y2);
            #endregion
            #region Вывод расстояния между 2 точками
            NameSpaceLesson1.Program.CalculatingDistance(x1, y1, x2, y2);
            #endregion
            NameSpaceLesson1.Program.EndProgramm();
            NameSpaceLesson1.Program.CloseProgrammKey();
        }
    }
}
