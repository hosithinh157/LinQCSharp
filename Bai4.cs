using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuchanhCS
{
    class Bai4
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

                var sortedDescending = numbers.OrderByDescending(x => x).ToList();

                Console.WriteLine("\nDanh sach sau khi sap xep giam dan:");
                Console.WriteLine(string.Join(" ", sortedDescending));
            }
            else
            {
                Console.WriteLine("So luong khong hop le!");
            }
            Console.ReadKey();
        }
    }
}
