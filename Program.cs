

namespace Lab2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var employees = Repository.getEmployeeList();
            var departments = Repository.getDepartmentsList();
            // First 4 Employees in the List Using Method Syntax[fluent syntax].

            var q1 = employees.Take(3);
            foreach (var employee in q1) { Console.WriteLine(employee); }
            //First 3 Employees in the List with Salary more than 5000 Using Method Syntax[fluent syntax].
            var q2 = employees.Where(e => e.Salary > 5000).Take(3);
            foreach (var employee in q2) { Console.WriteLine(employee); }
            //Last 4 Employees in the List Using Method Syntax[fluent syntax].
            var q3 = employees.TakeLast(3);
            foreach (var employee in q3) { Console.WriteLine(employee); }
            //Second 2 Employees in the List Using Method Syntax[fluent syntax].
            var q4 = employees.Where((e, i) => i > 1 && i < 4);
            foreach (var employee in q4) { Console.WriteLine(employee); }
            //All Employees While Name length < 5 Using Method Syntax[fluent syntax].
            var q5 = employees.TakeWhile(e => e.Name.Length < 5);
            foreach (var employee in q5) { Console.WriteLine(employee); }
            //Distinct Employees. Hint: (Using IEqualityComparer) Using Method Syntax[fluent syntax].
            EmployeeComparer empComparer = new EmployeeComparer();
            var q6 = employees.Distinct(empComparer);
            foreach (var employee in q6) { Console.WriteLine(employee); }
            //Name and Id of All Employees Using Method Syntax[fluent syntax].
            var q7 = employees.Select(e => new { e.Id, e.Name });
            foreach (var employee in q7) { Console.WriteLine(employee); }
            //Name and Id of All Employees Using Query Syntax.
            var q8 = from emp in employees
                     select new { emp.Id, emp.Name };
            foreach (var emp in q8) { Console.WriteLine(emp); }
            //Name and DeptName of All Employees Using Query Syntax.
           var q9 = from emp in employees
                    join dept in departments
                    on emp.DeptId equals dept.DeptId
                    select new { emp.Name, dept.DeptName };
            foreach (var emp in q9) { Console.WriteLine(emp); }
            //Name and DeptName of All Employees Using Method Syntax[fluent syntax].
            var q10 = employees.
                Join
                (
                departments,
                (e => e.DeptId),
                (d => d.DeptId),
                ((e, d) => new { e.Name, d.DeptName })
                );
            foreach (var emp in q10) { Console.WriteLine(emp); }
            //All Employees Group by DeptName Using Method Syntax[fluent syntax].
            var q11 = employees.
                Join
                (
                departments,
                (e => e.DeptId),
                (d => d.DeptId),
                ((e, d) => new { e, d.DeptName })
                ).GroupBy(d => d.DeptName);
            foreach (var group in q11)
            {
                Console.WriteLine(group.Key);
                foreach (var item in group)
                {
                    Console.WriteLine(item);
                }
            }
            //All Employees Group by DeptName Using Query Syntax.
            var q12 = from emp in employees
                      join dept in departments
                      on emp.DeptId equals dept.DeptId
                      group emp by dept.DeptName;
            foreach (var group in q12)
            {
                Console.WriteLine(group.Key);
                foreach (var item in group)
                {
                    Console.WriteLine(item);
                }
            }
            //Min Salary, Max Salary, Avg Salary.
            var q13 = employees.Max(e => e.Salary);
            var q14 = employees.Min(e => e.Salary);
            var q15 = employees.Average(e => e.Salary);
            Console.WriteLine($"Max: {q13}, Min: {q14}, Average: {q15}");
            //Employee Where Salary<Avg Salary.
            var q16 = employees.Where(e => e.Salary < q15);
            foreach (var emp in q16)
            {
                Console.WriteLine(emp);
            }
            //Create two lists of int and try Expect, Concat, Union, Intersect
            var l1 = new List<int> { 1, 2, 3, 4, 5, 6 };
            var l2 = new List<int> {4, 5, 6, 7, 8, 9};
            //concat
            var q17 = l1.Concat(l2);
            foreach (var item in q17)
            {
                Console.WriteLine(item);
            }
            //intersect
            var q18 = l1.Intersect(l2);
            foreach (var item in q18)
            {
                Console.WriteLine(item);
            }
            //// except
            var q19 = l1.Except(l2);
            foreach (var item in q19)
            {
                Console.WriteLine(item);
            }
            //// union
            var q20 = l1.Union(l2);
            foreach (var item in q20)
            {
                Console.WriteLine(item);
            }
            //Create list of Phone Number and Names and try Zip Operator.
            var list1 = new List<int> { 1, 2, 3, 4, };
            var list2 = new List<char> { 'A', 'B', 'C', 'D' };
            var q21 = list1.Zip(list2);
            foreach (var item in q21)
            {
                Console.WriteLine(item);
            }
        }
    }
}