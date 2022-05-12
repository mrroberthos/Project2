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
            int picture;
            int row = 3;
            Console.WriteLine("Сколько у вас картин: ");
            picture = Convert.ToInt32(Console.ReadLine());
            int turnOut = picture / row;
            int enumeration = picture % row;
            Console.WriteLine($"Заполненных рядов: {turnOut}. Осталось картин: {enumeration}.");

        }

    }
}