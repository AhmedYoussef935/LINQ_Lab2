

namespace Lab2
{
    public class Department
    {
        // properties
        public int DeptId { get; set; }
        public string? DeptName { get; set; }
        // default constructor
        public Department()
        {
            DeptId = 0;
            DeptName = null;
        }
        // parameterized constructor
        public Department(int deptId, string deptName)
        {
            DeptId = deptId;
            DeptName = deptName;
        }
        // methods
        public override string ToString()
        {
            return $"DeptId: {DeptId}, Name: {DeptName}";
        }
    }
}
