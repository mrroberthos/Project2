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
            int oldladies;
            int time = 10;
            int hours;
            int minutes;
            Console.WriteLine("Введите количество старушек");
            oldladies = Convert.ToInt32(Console.ReadLine());
            hours = (oldladies * time) / 60;
            minutes = (oldladies * time) % 60;
            Console.WriteLine($"Вы должны отстоять в очереди {hours} часа и {minutes} минут.");
        }
    }
}

