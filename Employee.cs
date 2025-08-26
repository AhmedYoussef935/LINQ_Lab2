

namespace Lab2
{
    public class Employee
    {
        // properties
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public float Salary { get; set; }
        public int DeptId { get; set; }
        // default constructor
        public Employee()
        {
            Id = 0;
            Name = null;
            Age = 0;
            Salary = 0;
            DeptId = 0;
        }
        // parameterized constructor
        public Employee(int id, string name, int age, float salary, int deptId)
        {
            Id = id;
            Name = name;
            Age = age;
            Salary = salary;
            DeptId = deptId;
        }
        // methods
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}, Salary: {Salary}, DeptId: {DeptId}";
        }
    }
}
