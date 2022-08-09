using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Exif
{
    class Program
    {
        static void Main(string[] args)
        {
            var intUsefulProperties = new int[] { 271, 272, 305, 36867, 36868 };

            Bitmap realImage = new Bitmap(@"real.jpg");
            Console.WriteLine("REAL IMAGE");
            Console.WriteLine("**********");
            foreach (var property in realImage.PropertyItems)
            {
                if (intUsefulProperties.Any(p => p == property.Id))
                {
                    Console.WriteLine(property.Id + " " + property.Type + "  " + Encoding.UTF8.GetString(property.Value).Trim());
                }
               
            }

            Console.WriteLine();

            Console.WriteLine("FAKE IMAGE");
            Console.WriteLine("**********");
            Bitmap fakeImage = new Bitmap(@"fake.jpg");
            foreach (var property in fakeImage.PropertyItems)
            {
                if (intUsefulProperties.Any(p => p == property.Id))
                {
                    Console.WriteLine(property.Id + " " + property.Type + "  " + Encoding.UTF8.GetString(property.Value).Trim());
                }
                
            }
        }
    }
}
