using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Globalization;

#region Условия задачи
//С помощью рефлексии выведите все свойства структуры DateTime
#endregion
namespace Hw1
{
    class Program
    {
        static PropertyInfo GetPropertyInfo(object obj, string str)
        {
            return obj.GetType().GetProperty(str);
        }


        static void Main(string[] args)
        {
            Type type = typeof(int);
            Console.WriteLine(type);
            int i = 0;
            Type type2 = i.GetType();
            Console.WriteLine(type2);
            Console.ReadKey();

            DateTime dateTime = new DateTime();
            //dateTime.DayOfWeek
            Extraction(dateTime, "Date");
            Extraction(dateTime, "Day");
            Extraction(dateTime, "DayOfWeek");
            Extraction(dateTime, "DayOfYear");
            Extraction(dateTime, "Hour");
            Extraction(dateTime, "Kind");
            Extraction(dateTime, "Millisecond");
            Extraction(dateTime, "Minute");
            Extraction(dateTime, "Month");
            Extraction(dateTime, "Now");
            Extraction(dateTime, "Second");
            Extraction(dateTime, "Ticks");
            Extraction(dateTime, "TimeOfDay");
            Extraction(dateTime, "Today");
            Extraction(dateTime, "UtcNow");
            Extraction(dateTime, "Year");
            Console.WriteLine("Конец! Нажмите на любую кнопку для завершения!");
            Console.ReadKey();
            Console.ReadKey();

        }

        private static void Extraction(DateTime dateTime, string property)
        {
            Console.WriteLine(GetPropertyInfo(dateTime, property).CanRead);
            Console.WriteLine(GetPropertyInfo(dateTime, property).CanWrite);
            Console.WriteLine(GetPropertyInfo(dateTime, property).GetValue(dateTime, null));
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
