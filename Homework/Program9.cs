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
            int initialValue = 5;

            for (initialValue = 5; initialValue <= maximumValue; initialValue += changingValue)
            {
                Console.WriteLine(initialValue);
            }
        }
    }
}
