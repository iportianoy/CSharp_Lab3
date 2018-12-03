/* 
 * Портяний Іван, ІС-63, Варіант 14
 * 14)	Реализовать задачу конвертации изображения,
 * загруженного пользователем с заданного адреса,
 * в выбранный пользователем формат (.jpeg, .gif, .png)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            JPEGConverter jpegConverter = new JPEGConverter();
            PNGConverter pngConverter = new PNGConverter();
            GIFConverter gifConverter = new GIFConverter();

            Image img = new Image("img", ".jpg", jpegConverter);
            img.Describe();
            Console.WriteLine("-----------------------------");

            img.Convert();
            Console.WriteLine("-----------------------------");

            img.converter = pngConverter;
            img.Convert();
            Console.WriteLine("-----------------------------");

            img.converter = gifConverter;
            img.Convert();
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Press any key...");
            Console.Read();

        }
    }
}
