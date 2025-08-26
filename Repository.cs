

namespace Lab2
{
    public static class Repository
    {
        public static List<Department> getDepartmentsList() {
            return new List<Department>
            {
                new Department { DeptId = 1, DeptName = "HR" },
                new Department { DeptId = 2, DeptName = "IT" },
                new Department { DeptId = 3, DeptName = "Finance" },
                new Department { DeptId = 4, DeptName = "Marketing" },
                new Department { DeptId = 10, DeptName = "Sales" }
            };
        }
        public static List<Employee> getEmployeeList()
        {
            return new List<Employee>
            {
                new Employee { Id = 3, Name = "Ali", Age = 25, Salary = 5000, DeptId = 1 },
                new Employee { Id = 10, Name = "Sara", Age = 28, Salary = 6000, DeptId = 2 },
                new Employee { Id = 4, Name = "Omar", Age = 30, Salary = 7000, DeptId = 3 },
                new Employee { Id = 8, Name = "Mona", Age = 26, Salary = 5500, DeptId = 4 },
                new Employee { Id = 7, Name = "Hassan", Age = 35, Salary = 8000, DeptId = 10 },
                new Employee { Id = 1, Name = "Omar", Age = 40, Salary = 9000, DeptId = 1 },
                new Employee { Id = 5, Name = "Nora", Age = 24, Salary = 4800, DeptId = 3 },
                new Employee { Id = 14, Name = "Mahmoud", Age = 32, Salary = 7500, DeptId = 3 },
                new Employee { Id = 11, Name = "Rania", Age = 29, Salary = 6200, DeptId = 4 },
                new Employee { Id = 2, Name = "Samir", Age = 27, Salary = 5800, DeptId = 10 },
                new Employee { Id = 6, Name = "Huda", Age = 31, Salary = 7200, DeptId = 1 },
                new Employee { Id = 9, Name = "Youssef", Age = 34, Salary = 8500, DeptId = 2 },
                new Employee { Id = 15, Name = "Amal", Age = 23, Salary = 4700, DeptId = 3 },
                new Employee { Id = 13, Name = "Adel", Age = 36, Salary = 8800, DeptId = 4 },
                new Employee { Id = 12, Name = "Laila", Age = 28, Salary = 6100, DeptId = 10 }
            };
        }
    }
}
