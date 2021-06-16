using System;

namespace Part3Ex2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var highSchool = new HighschoolTeacher
            {
                IdentityNumber = "ID001",
                Name = "SP",
                BaseSalary = 100,
                Level = 1,
                Bonus = 200,
                IsSenior = false,
                HighschoolCode = "HS001"
            };
            Console.WriteLine(highSchool.Salary());
            var university = new UniversityTeacher()
            {
                IdentityNumber = "ID001",
                Name = "SP",
                BaseSalary = 100,
                Level = 1,
                Bonus = 200,
                IsSenior = true,
                EnglishLevel = 3,
                UniversityCode = "HS003"
            };
            Console.WriteLine(university.Salary());
        }
    }
}