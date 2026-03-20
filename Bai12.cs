using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuchanhCS
{
    public class Student4
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }
    }

    class Bai12
    {
        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Hồ Sĩ Thịnh");
            Console.Write("\nMSV: 23115053122239");
            List<Student4> students = new List<Student4>()
            {
                new Student4 { Id = 1, Name = "An", Score = 8 },
                new Student4 { Id = 2, Name = "Binh", Score = 6 },
                new Student4 { Id = 3, Name = "Chi", Score = 9 },
                new Student4 { Id = 4, Name = "Dung", Score = 7 }
            };

            int countPassed = students.Count(x => x.Score >= 7);

            Console.WriteLine("\n=== THONG KE KET QUA ===");
            Console.WriteLine($"So luong sinh vien dat (Diem >= 7) la: {countPassed}");

            var passedNames = students.Where(x => x.Score >= 7).Select(x => x.Name);
            Console.WriteLine($"Cac sinh vien do la: {string.Join(", ", passedNames)}");

            Console.ReadKey();
        }
    }
}
