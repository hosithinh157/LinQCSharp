using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuchanhCS
{
    public class Student6
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }
    }

    class Bai14
    {
        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Hồ Sĩ Thịnh");
            Console.Write("\nMSV: 23115053122239");
            List<Student6> students = new List<Student6>()
            {
                new Student6 { Id = 1, Name = "An", Score = 8 },
                new Student6 { Id = 2, Name = "Binh", Score = 6 },
                new Student6 { Id = 3, Name = "Chi", Score = 9 },
                new Student6 { Id = 4, Name = "Dung", Score = 7 }
            };

            bool hasFailedStudent = students.Any(s => s.Score < 5);

            Console.WriteLine("\n=== KIEM TRA KET QUA HOC TAP ===");

            if (hasFailedStudent)
            {
                Console.WriteLine("Ket qua: CO sinh vien bi rot (Diem < 5).");
            }
            else
            {
                Console.WriteLine("Ket qua: Tat ca sinh vien deu DAT (Khong co ai diem < 5).");
            }

            Console.ReadKey();
        }
    }
}
