using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuchanhCS
{
    public class Student3
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }

        public override string ToString()
        {
            return $"ID: {Id} | Ten: {Name} | Diem cao nhat: {Score}";
        }
    }

    class Bai11
    {
        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Hồ Sĩ Thịnh");
            Console.Write("\nMSV: 23115053122239");
            List<Student3> students = new List<Student3>()
            {
                new Student3 { Id = 1, Name = "An", Score = 8 },
                new Student3 { Id = 2, Name = "Binh", Score = 6 },
                new Student3 { Id = 3, Name = "Chi", Score = 9 },
                new Student3 { Id = 4, Name = "Dung", Score = 7 }
            };

            var topStudent = students.MaxBy(s => s.Score);

            Console.WriteLine("\n=== SINH VIEN CO DIEM CAO NHAT ===");
            if (topStudent != null)
            {
                Console.WriteLine(topStudent.ToString());
            }

            Console.ReadKey();
        }
    }
}
