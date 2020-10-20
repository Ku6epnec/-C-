using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
// Класс XmlSerializer требует, чтобы все сериализованные типы
// поддерживали конструктор по умолчанию (поэтому не забудьте его добавить, если определяли специальные конструкторы). Если этого не сделать, во время выполнения сгенерируется исключение InvalidOperationException.


#region Условия задачи
/*а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок (не создана база данных, обращение к несуществующему вопросу, открытие слишком большого файла и т.д.).
б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов и добавив другие «косметические» улучшения на свое усмотрение.
в) Добавить в приложение меню «О программе» с информацией о программе (автор, версия, авторские права и др.).
г)*Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных (элемент SaveFileDialog).*/
#endregion


namespace Hw3
{
    [Serializable]
    public class Student
    {
        public string firstName;
        public string lastName;
        int age;      
        public int Age
        {
            get { return age; }
            set { if (value > 0) age = value; }
        }
        public Student(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
        public Student()
        {
        }
    }
    class Program
    {
        static void SaveAsXmlFormat(List<Student> obj, string fileName)
        {
            
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, obj);
            fStream.Close();
        }
        static void LoadFromXmlFormat(ref List<Student> obj, string fileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            obj = (List<Student>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            list.Add(new Student("Иван", "Иванов", 20));
            list.Add(new Student("Петр", "Петров", 21));
            SaveAsXmlFormat(list, "data.xml");
            LoadFromXmlFormat(ref list, "data.xml");
            foreach (var v in list)
            {
                Console.WriteLine("{0} {1} {2}", v.firstName, v.lastName, v.Age);
            }
            Console.ReadKey();
        }

    }
}

