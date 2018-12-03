using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Image
    {
        public string name;
        public string extension;

        public IConverter converter { private get; set; }

        public Image(string name, string extension, IConverter converter)
        {
            this.name = name;
            this.extension = extension;
            this.converter = converter;
        }

        public void Convert()
        {
            converter.Convert(this);
            this.Describe();
        }

        public void Describe()
        {
            Console.Write("Name of the file: ");
            Console.WriteLine(this.name + this.extension);
        }



    }
}
