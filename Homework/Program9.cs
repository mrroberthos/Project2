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
            int changingValue = 7
            int startValue = 5;
                
            for (int i = startValue; i <= maximumValue; i += changingValue)
            {
                Console.WriteLine(i);
            }
        }
    }
}
