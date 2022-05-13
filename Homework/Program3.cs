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
            string name = "test1";
            string surname = "test2";
            string temp;
            temp = name;
            name = surname;
            surname = temp;
            Console.WriteLine(name + " " + surname);
        }
    }
}
