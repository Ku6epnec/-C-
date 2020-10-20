using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Обмен значениями двух переменных с использованием третьей
            NameSpaceLesson1.Program.ChangeTwoVariables();
            #endregion
            #region Обмен числовых переменных без третьей переменной:
            int a = 1;
            int b = 2;
            a = a + b;
            b = a - b;
            a = a - b;
            #endregion
            NameSpaceLesson1.Program.EndProgramm();
            NameSpaceLesson1.Program.CloseProgrammKey();
        }
    }
}
