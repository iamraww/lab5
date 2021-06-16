namespace Part3Ex2
{
    public abstract class Person
    {
        public string IdentityNumber { get; set; }
        public string Name { get; set; }
        public double BaseSalary { get; set; }
        public int Level { get; set; }
        public bool IsSenior { get; set; }
        public double Bonus { get; set; }
        public abstract double Salary(); 
    }
}