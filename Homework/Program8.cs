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
            string userInput;
            Console.WriteLine("Введите пароль или напишете exit");
            userInput = Console.ReadLine();

            while (userInput != "exit")
            { 
                Console.WriteLine("Попробуй ещё");
                userInput = Console.ReadLine();
            }
        }
    }
}
