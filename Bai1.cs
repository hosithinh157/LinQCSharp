using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuchanhCS
{
    public class Bai1
    {
        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Hồ Sĩ Thịnh");
            Console.Write("\nMSV: 23115053122239");
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

            Console.WriteLine("\nDanh sach goc: " + string.Join(", ", numbers));
            Console.WriteLine("Cac so chan la: " + string.Join(", ", evenNumbers));
            Console.ReadKey();
        }
    }
}
