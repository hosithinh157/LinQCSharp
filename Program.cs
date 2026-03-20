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
                Console.WriteLine("15. Bai 15");
                Console.WriteLine("16. Bai 16");
                Console.WriteLine("17. Bai 17");
                Console.WriteLine("18. Bai 18");
                Console.WriteLine("19. Bai 19");
                Console.WriteLine("20. Bai 20");
                Console.WriteLine("21. Bai Ex");
                Console.WriteLine("0. Thoát");
                Console.Write("Chon bai: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 15:
                        Bai15.Run();
                        break;
                    case 16:
                        Bai16.Run();
                        break;
                    case 17:
                        Bai17.Run();
                        break;
                    case 18:
                        Bai18.Run();
                        break;
                    case 19:
                        Bai19.Run();
                        break;
                    case 20:
                        Bai20.Run();
                        break;
                    case 21:
                        BaiEx.Run();
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