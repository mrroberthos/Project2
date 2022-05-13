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
            int pictures;
            int picturesInRow = 3;
            Console.WriteLine("Сколько у вас картин: ");
            pictures = Convert.ToInt32(Console.ReadLine());
            int filledRows = pictures / picturesInRow;
            int remainsPictures = pictures % picturesInRow;
            Console.WriteLine($"Заполненных рядов:{filledRows}. Осталось картин:{remainsPictures}.");
        }
    }
}
