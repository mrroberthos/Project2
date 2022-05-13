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
            int receptionTime = 10;
            int waitingHour = 60;
            int waitingMinutes;
            Console.WriteLine("Введите количество старушек");
            oldladies = Convert.ToInt32(Console.ReadLine());
            waitingHour = (oldladies * receptionTime) / waitingHour;
            waitingMinutes = (oldladies * receptionTime) % waitingHour;
            Console.WriteLine($"Вы должны отстоять в очереди {waitingHour} часа и {waitingMinutes} минут.");
        }
    }
}

