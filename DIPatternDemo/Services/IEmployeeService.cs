﻿using DIPatternDemo.Models;

namespace DIPatternDemo.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployeeById(int id);
        int AddEmployee(Employee employee);
        int EditEmpoyee(Employee employee);
        int DeleteEmployee(int id);
    }
}
