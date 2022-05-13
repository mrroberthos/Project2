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
            int gold;
            int cristallsCount;
            int cristallPrice = 20;
            Console.WriteLine($"Добро пожаловать в магазин кристаллов! Сегодня кристаллы по {cristallPrice} золота.");
            Console.WriteLine("Сколько у вас золота?");
            gold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сколько вам нужно кристаллов?");
            cristallsCount = Convert.ToInt32(Console.ReadLine());
            gold -= cristallsCount * cristallPrice; 
            Console.WriteLine($"У вас в сумке - {cristallsCount} кристаллов и {gold} золота.");
        }
    }
}
