using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuchanhCS
{
    public class Student1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }
    }

    class Bai9
    {
        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Hồ Sĩ Thịnh");
            Console.Write("\nMSV: 23115053122239");
            List<Student1> students = new List<Student1>()
            {
                new Student1 { Id = 1, Name = "An", Score = 8 },
                new Student1 { Id = 2, Name = "Binh", Score = 6 },
                new Student1 { Id = 3, Name = "Chi", Score = 9 },
                new Student1 { Id = 4, Name = "Dung", Score = 7 }
            };

            var studentNames = students.Select(s => s.Name).ToList();

            Console.WriteLine("\n=== DANH SACH TEN SINH VIEN ===");
            Console.WriteLine(string.Join(" ", studentNames));

            Console.ReadKey();
        }
    }
}
