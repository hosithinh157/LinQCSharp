using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuchanhCS
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }
    }

    class Bai17
    {
        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Hồ Sĩ Thịnh");
            Console.Write("\nMSV: 23115053122239");
            List<Student> students = new List<Student>()
            {
                new Student { Id = 1, Name = "An", Score = 8 },
                new Student { Id = 2, Name = "Binh", Score = 6 },
                new Student { Id = 3, Name = "Chi", Score = 9 },
                new Student { Id = 4, Name = "Dung", Score = 7 }
            };

            double averageScore = students.Average(s => s.Score);

            Console.WriteLine("\n=== THONG KE DIEM TRUNG BINH ===");
            Console.WriteLine($"Diem trung binh cua ca lop la: {averageScore:F2}");

            Console.WriteLine($"Tong so sinh vien: {students.Count}");

            Console.ReadKey();
        }
    }
}
