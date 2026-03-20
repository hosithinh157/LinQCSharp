using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuchanhCS
{
    class Bai3
    {
        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Hồ Sĩ Thịnh");
            Console.Write("\nMSV: 23115053122239");
            List<int> numbers = new List<int>();

            Console.Write("\nNhap so luong phan tu trong danh sach: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            var sortedNumbers = numbers.OrderBy(x => x).ToList();

            Console.WriteLine("\nDanh sach sau khi sap xep tang dan:");
            Console.WriteLine(string.Join(" ", sortedNumbers));
            Console.ReadKey();
        }
    }
}
