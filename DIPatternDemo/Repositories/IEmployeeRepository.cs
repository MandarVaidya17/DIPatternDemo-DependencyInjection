using DIPatternDemo.Models;

namespace DIPatternDemo.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployeeById(int id);
        int AddEmployee(Employee employee);
        int EditEmpoyee(Employee employee);
        int DeleteEmployee(int id);
    }
}
