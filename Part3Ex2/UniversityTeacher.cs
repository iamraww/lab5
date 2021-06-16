﻿namespace Part3Ex2
{
    public class UniversityTeacher: Person
    {
        public string UniversityCode { get; set; }
        public int EnglishLevel { get; set; }
        public override double Salary()
        {
            if (Bonus > 10000)
            {
                throw new AmountException("Bonus is more than 10.000", Name);
            }

            var salary = BaseSalary * Level + ((BaseSalary / 10) * EnglishLevel) + Bonus;
            if (IsSenior && salary < 60000)
            {
                throw new AmountException("Senior Lecturer gets less than 60,000 salary", Name);
            }

            return salary;
        }
    }
}