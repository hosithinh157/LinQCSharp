using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuchanhCS
{
    class Bai16
    {
        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Hồ Sĩ Thịnh");
            Console.Write("\nMSV: 23115053122239");
            List<int> numbers = new List<int>();

            Console.Write("\nNhap so luong phan tu n: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Nhap phan tu thu {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out int num))
                    {
                        numbers.Add(num);
                    }
                    else
                    {
                        Console.WriteLine("Gia tri khong hop le, vui long nhap lai so nguyen.");
                        i--; 
                    }
                }

                int totalSum = numbers.Sum();

                Console.WriteLine("\n----------------------------");
                Console.WriteLine("Danh sach ban da nhap: " + string.Join(" ", numbers));
                Console.WriteLine($"Tong cac phan tu trong danh sach la: {totalSum}");
            }
            else
            {
                Console.WriteLine("So luong phan tu phai la so nguyen duong.");
            }

            Console.ReadKey();
        }
    }
}
