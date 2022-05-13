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
            int minutesPerHour = 60;
            Console.WriteLine("Введите количество старушек");
            oldladies = Convert.ToInt32(Console.ReadLine());
            waitingHour = (oldladies * receptionTime) / minutesPerHour;
            Console.WriteLine($"Вы должны отстоять в очереди {waitingHour} часа и {waitingHour} минут.");
    }
}

