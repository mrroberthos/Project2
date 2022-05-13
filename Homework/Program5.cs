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
            int waitingHour;
            int waitingMinutes = 60;
            Console.WriteLine("Введите количество старушек");
            oldladies = Convert.ToInt32(Console.ReadLine());
            waitingHour = (oldladies * receptionTime) / waitingMinutes;
            waitingMinutes = (oldladies * receptionTime) % waitingMinutes;
            Console.WriteLine($"Вы должны отстоять в очереди {waitingHour} часа и {waitingMinutes} минут.");
        }
    }
}

