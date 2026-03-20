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
        public int BirthYear { get; set; }
        public string Faculty { get; set; }

        public double ScoreNetworking { get; set; } 
        public double ScoreProgramming { get; set; } 
        public double ScoreDatabase { get; set; } 

        public double AverageScore => Math.Round((ScoreNetworking + ScoreProgramming + ScoreDatabase) / 3, 2);

        public int Age => 2026 - BirthYear;

        public string StudentYear
        {
            get
            {
                int yearsInUni = 2026 - (BirthYear + 18);
                if (yearsInUni <= 0) return "Nam nhat";
                if (yearsInUni == 1) return "Nam hai";
                if (yearsInUni == 2) return "Nam ba";
                return "Nam cuoi";
            }
        }

        public override string ToString()
        {
            return $"ID: {Id,-2} | {Name,-12} | Tuoi: {Age} | {StudentYear,-8} | DTB: {AverageScore,5} | Khoa: {Faculty}";
        }
    }

    class BaiEx
    {
        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Hồ Sĩ Thịnh");
            Console.Write("\nMSV: 23115053122239");
            Random rand = new Random();
            List<Student3> students = new List<Student3>();
            string[] names = { "An", "Binh", "Chi", "Dung", "Em", "Giang", "Hoa", "Hung", "Khoa", "Lan",
                               "Linh", "Minh", "Nam", "Oanh", "Phuc", "Quang", "Son", "Tu", "Van", "Yen" };

            for (int i = 0; i < 20; i++)
            {
                students.Add(new Student3
                {
                    Id = i + 1,
                    Name = names[i],
                    BirthYear = rand.Next(2004, 2008),
                    Faculty = "Cong nghe so",
                    ScoreNetworking = rand.Next(4, 11),
                    ScoreProgramming = rand.Next(4, 11),
                    ScoreDatabase = rand.Next(4, 11)
                });
            }

            Console.WriteLine("=== DANH SACH 20 SINH VIEN BAN DAU ===");
            students.ForEach(s => Console.WriteLine(s));


            Console.WriteLine("\n" + new string('-', 60));

            int maxAge = students.Max(s => s.Age);
            int minAge = students.Min(s => s.Age);
            Console.WriteLine($"1. Tuoi lon nhat: {maxAge} | Tuoi nho nhat: {minAge}");

            bool hasCNS = students.Any(s => s.Faculty == "Cong nghe so");
            Console.WriteLine($"2. Co sinh vien thuoc khoa Cong nghe so khong? {(hasCNS ? "Co" : "Khong")}");

            Console.WriteLine("\n3. Top 10 sinh vien DTB cao nhat khoa Cong nghe so:");
            var top10CNS = students.Where(s => s.Faculty == "Cong nghe so")
                                   .OrderByDescending(s => s.AverageScore)
                                   .Take(10);
            foreach (var s in top10CNS) Console.WriteLine(s);

            Console.WriteLine("\n4. Danh sach sinh vien CHUA PHAI nam cuoi:");
            var notFinalYear = students.Where(s => s.StudentYear != "Nam cuoi").ToList();
            if (notFinalYear.Any())
            {
                notFinalYear.ForEach(s => Console.WriteLine(s));
            }
            else
            {
                Console.WriteLine("Tat ca deu la sinh vien nam cuoi.");
            }

            Console.ReadKey();
        }
    }
}
