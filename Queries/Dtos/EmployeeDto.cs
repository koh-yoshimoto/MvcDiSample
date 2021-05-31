namespace MvcSample.Queries.Dtos
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Name { get { return LastName + FirstName; } }

        public int Salary { get; set; }

        public int DepartmentId { get; set; }
    }
}