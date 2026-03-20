using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuchanhCS
{
    class Bai7
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

                var numbersGreaterThan10 = numbers.Where(x => x > 10).ToList();

                int count = numbersGreaterThan10.Count;

                Console.WriteLine("\n----------------------------");

                if (count > 0)
                {
                    Console.WriteLine($"Ket qua: CO {count} so lon hon 10 trong danh sach.");
                    Console.WriteLine("Cac so do la: " + string.Join(", ", numbersGreaterThan10));
                }
                else
                {
                    Console.WriteLine("Ket qua: KHONG co so nao lon hon 10.");
                }
            }
            else
            {
                Console.WriteLine("So luong khong hop le!");
            }

            Console.ReadKey();
        }
    }
}
