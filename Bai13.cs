using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuchanhCS
{
    public class Student5
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }

        public override string ToString()
        {
            return $"[Tim thay] ID: {Id} | Ten: {Name} | Diem: {Score}";
        }
    }

    class Bai13
    {
        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Hồ Sĩ Thịnh");
            Console.Write("\nMSV: 23115053122239");
            List<Student5> students = new List<Student5>()
            {
                new Student5 { Id = 1, Name = "An", Score = 8 },
                new Student5 { Id = 2, Name = "Binh", Score = 6 },
                new Student5 { Id = 3, Name = "Chi", Score = 9 },
                new Student5 { Id = 4, Name = "Dung", Score = 7 }
            };

            var firstStudent = students.FirstOrDefault(x => x.Score > 7);

            Console.WriteLine("\n=== TIM KIEM SINH VIEN DAU TIEN CO DIEM > 7 ===");

            if (firstStudent != null)
            {
                Console.WriteLine(firstStudent.ToString());
            }
            else
            {
                Console.WriteLine("Khong tim thay sinh vien nao co diem > 7.");
            }

            Console.ReadKey();
        }
    }
}
