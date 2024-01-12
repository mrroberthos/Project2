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
            string name;
            int age;
            string zodiac;
            string job;
            Console.Write("Введите ваше имя:");
            name = Console.ReadLine();
            Console.Write("Введите ваш возраст:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ваш знак зодиака:");
            zodiac = Console.ReadLine();
            Console.Write("Введите ваше место работы:");
            job = Console.ReadLine();
            Console.WriteLine($"Вас зовут {name}. Ваш возраст {age}. Знак зодиака {zodiac}. Место работы {job}.");
        }
    }
}
