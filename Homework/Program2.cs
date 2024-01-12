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
            int pictures = 52;
            int picturesInRow = 3;
            int filledRows = pictures / picturesInRow;
            int remainsPictures = pictures % picturesInRow;
            Console.WriteLine($"Заполненных рядов:{filledRows}. Осталось картин:{remainsPictures}.");
        }
    }
}
