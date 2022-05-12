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
            int picture;
            int picturesInARow = 3;
            Console.WriteLine("Сколько у вас картин: ");
            picture = Convert.ToInt32(Console.ReadLine());
            int rowsWithPictures = picture / picturesInARow;
            int remainsPictures = picture % picturesInARow;
            Console.WriteLine($"Заполненных рядов:{rowsWithPictures}. Осталось картин:{remainsPictures}.");

        }

    }
}
