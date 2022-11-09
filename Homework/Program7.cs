using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Практика_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Message;
            Console.WriteLine("Введите своё сообщение:");
            Message = Console.ReadLine();
            int repeatsMessage;
            Console.WriteLine("Введите кол-во повторений сообщения:");
            repeatsMessage = Convert.ToInt32(Console.ReadLine());

            while (repeatsMessage-- > 0)
            {
                Console.WriteLine(Message);
            }
        }
    }
}
