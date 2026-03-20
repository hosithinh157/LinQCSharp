using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuchanhCS
{
    class Bai15
    {
        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Hồ Sĩ Thịnh");
            Console.Write("\nMSV: 23115053122239");
            List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };

            Console.WriteLine("\nDanh sach goc: " + string.Join(" ", numbers));

            var uniqueNumbers = numbers.Distinct().ToList();

            Console.WriteLine("----------------------------");
            Console.WriteLine("Danh sach sau khi loai bo trung: " + string.Join(" ", uniqueNumbers));

            Console.ReadKey();
        }
    }
}
