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
                Console.WriteLine("8. Bai 8");
                Console.WriteLine("9. Bai 9");
                Console.WriteLine("10. Bai 10");
                Console.WriteLine("11. Bai 11");
                Console.WriteLine("12. Bai 12");
                Console.WriteLine("13. Bai 13");
                Console.WriteLine("14. Bai 14");
                Console.WriteLine("0. Thoát");
                Console.Write("Chon bai: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 8:
                        Bai8.Run();
                        break;
                    case 9:
                        Bai9.Run();
                        break;
                    case 10:
                        Bai10.Run();
                        break;
                    case 11:
                        Bai11.Run();
                        break;
                    case 12:
                        Bai12.Run();
                        break;
                    case 13:
                        Bai13.Run();
                        break;
                    case 14:
                        Bai14.Run();
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