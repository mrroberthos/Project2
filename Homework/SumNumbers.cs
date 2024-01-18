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
            int number;
            int randomMinimumNumber = 0;
            int randomMaximumNumber = 101;
            int firstMultipleNumber = 3;
            int secondMultipleNumber = 5;
            int sum = 0;
            Random random = new Random();

            number = random.Next(randomMinimumNumber, randomMaximumNumber);
            Console.WriteLine($"Рандомное число: {number}") ;

            for (int i = 0; i <= number;  i++)
            {
                if (i % firstMultipleNumber == 0 || i % secondMultipleNumber == 0)
                {
                    Console.WriteLine(i);
                    
                    sum += i;
                }
            }
                
            Console.WriteLine($"Сумма всех положительных чисел, которые меньше {number} (включая это число) и числа кратные {firstMultipleNumber} и {secondMultipleNumber}" +
                    $" равна: {sum}") ;
        }
    }
}
