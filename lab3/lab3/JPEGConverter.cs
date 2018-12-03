using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class JPEGConverter : IConverter
    {
        public void Convert(Image img)
        {
            img.extension = ".jpeg";
            Console.WriteLine("Converted to jpeg.");
        }
    }
}
