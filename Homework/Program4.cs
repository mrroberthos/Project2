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
            int cristallCount;
            int cristallPrice = 20;
            bool enoughGold;
            Console.WriteLine($"Добро пожаловать в магазин кристаллов! Сегодня кристаллы по {cristallPrice} золота.");
            Console.WriteLine("Сколько у вас золота?");
            gold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сколько вам нужно кристаллов");
            cristallCount = Convert.ToInt32(Console.ReadLine());
            gold -= cristallCount * cristallPrice; 
            Console.WriteLine($"У вас в сумке - {cristallCount} кристаллов и {gold} золота.");
        }
    }
}
