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
            string temp;
            temp = name;
            name = surname;
            surname = temp;
            Console.WriteLine(name + " " + surname);
        }
    }
}
