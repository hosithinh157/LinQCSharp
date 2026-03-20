using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuchanhCS
{
    class Bai6
    {
        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Hồ Sĩ Thịnh");
            Console.Write("\nMSV: 23115053122239");
            List<int> numbers = new List<int>();

            Console.Write("\nNhap so luong phan tu: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Nhap phan tu thu {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out int num))
                    {
                        numbers.Add(num);
                    }
                }

                int evenCount = numbers.Count(x => x % 2 == 0);

                Console.WriteLine("\n----------------------------");
                Console.WriteLine($"So luong cac so chan trong danh sach la: {evenCount}");
            }
            else
            {
                Console.WriteLine("So luong khong hop le!");
            }
            Console.ReadKey();
        }
    }
}
