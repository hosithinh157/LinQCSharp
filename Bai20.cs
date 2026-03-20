using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuchanhCS
{
    public class Student2
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }

        public override string ToString()
        {
            return $"ID: {Id} | Ten: {Name,-5} | Diem: {Score}";
        }
    }

    class Bai20
    {
        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Hồ Sĩ Thịnh");
            Console.Write("\nMSV: 23115053122239");
            List<Student2> students = new List<Student2>()
            {
                new Student2 { Id = 1, Name = "An", Score = 8 },
                new Student2 { Id = 2, Name = "Binh", Score = 6 },
                new Student2 { Id = 3, Name = "Chi", Score = 9 },
                new Student2 { Id = 4, Name = "Dung", Score = 7 }
            };

            var top3Students = students.OrderByDescending(s => s.Score)
                                       .Take(3)
                                       .ToList();

            Console.WriteLine("\n=== TOP 3 SINH VIEN DIEM CAO NHAT ===");
            int rank = 1;
            foreach (var s in top3Students)
            {
                Console.WriteLine($"Hang {rank}: {s}");
                rank++;
            }

            Console.ReadKey();
        }
    }
}
