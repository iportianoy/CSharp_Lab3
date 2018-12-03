using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class PNGConverter : IConverter
    {
        public void Convert(Image img)
        {
            img.extension = ".png";
            Console.WriteLine("Converted to png.");
        }
    }
}
