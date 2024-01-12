using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Mask";
            string surname = "Ilon";
            string patronymic;
            patronymic = name;
            name = surname;
            surname = patronymic;
            Console.WriteLine(name + " " + surname);
        }
    }
}
