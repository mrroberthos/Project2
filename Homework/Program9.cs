using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Первые_уроки
{
    class Program
    {
        static void Main(string[] args)
        {
            int maximumValue = 96;
            int changingValue = 7;

            for (int minimumValue = 5; minimumValue <= maximumValue; minimumValue += changingValue)
            {
                Console.WriteLine(minimumValue);
            }
        }
    }
}
