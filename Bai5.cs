using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuchanhCS
{
    class Bai5
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

                var squaredNumbers = numbers.Select(x => x * x).ToList();

                Console.WriteLine("\nDanh sach binh phuong cua cac so:");
                Console.WriteLine(string.Join(" ", squaredNumbers));
            }
            else
            {
                Console.WriteLine("So luong khong hop le!");
            }
            Console.ReadKey();
        }
    }
}
