using System;

namespace Part3Ex2
{
    public class HighschoolTeacher: Person
    {
        public string HighschoolCode { get; set; }
        public override double Salary()
        {
            if (Bonus > 10000)
            {
                throw new AmountException("Bonus is more than 10.000", Name);
            }

            var salary = BaseSalary * Level + Bonus;
            if (IsSenior && salary < 60000)
            {
                throw new AmountException("Senior Lecturer gets less than 60,000 salary", Name);
            }

            return salary;
        }
    }
}