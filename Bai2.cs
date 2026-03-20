using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuchanhCS
{
    class Bai2
    {
        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Hồ Sĩ Thịnh");
            Console.Write("\nMSV: 23115053122239");
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            var result = numbers.Where(n => n > 5).ToList();

            Console.WriteLine("\nCac so lon hon 5 la: " + string.Join(", ", result));
            Console.ReadKey();
        }
    }
}
