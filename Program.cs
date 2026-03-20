using System;
using System.Runtime.Intrinsics.X86;

namespace ThuchanhCS
{
    class Program
    {
        static void Main()
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("===== MENU CHUONG TRINH =====");
                Console.WriteLine("1. Bai 1");
                Console.WriteLine("2. Bai 2");
                Console.WriteLine("3. Bai 3");
                Console.WriteLine("4. Bai 4");
                Console.WriteLine("5. Bai 5");
                Console.WriteLine("6. Bai 6");
                Console.WriteLine("7. Bai 7");
                Console.WriteLine("0. Thoát");
                Console.Write("Chon bai: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Bai1.Run();
                        break;
                    case 2:
                        Bai2.Run();
                        break;
                    case 3:
                        Bai3.Run();
                        break;
                    case 4:
                        Bai4.Run();
                        break;
                    case 5:
                        Bai5.Run();
                        break;
                    case 6:
                        Bai6.Run();
                        break;
                    case 7:
                        Bai7.Run();
                        break;
                    case 0:
                        Console.WriteLine("Thoat chuong trinh...");
                        break;
                    default:
                        Console.WriteLine("Khong hop le");
                        break;
                }
            } while (choice != 0);
        }
    }
}