
using System.Data.Entity;


namespace EmployeeProject.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public int Age { get; set; }
        public string EmployeeName { get; set; }
        public string Gender { get; set; }
    }

    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }
    }
}