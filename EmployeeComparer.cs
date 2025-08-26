
namespace Lab2
{
    public class EmployeeComparer: IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            return x.Id == y.Id;
        }
        public int GetHashCode(Employee x)
        {
            return x.Id;
        }
    }
}
