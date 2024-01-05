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
            string closingProgram = "exit";
            string userInput;
 
            while (closingProgram == "exit") 
            {
                Console.WriteLine("Введите пароль или напишете exit");
                userInput = Console.ReadLine();
                if (userInput == closingProgram)
                {
                    Console.WriteLine("Пока");
                    break;
                }
                else
                {
                    Console.WriteLine("Пробуй ещё");
                }
            }
        }
    }
}