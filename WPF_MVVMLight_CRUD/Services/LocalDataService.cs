using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using WPF_MVVMLight_CRUD.Model;

namespace WPF_MVVMLight_CRUD.Services
{
    public class LocalDataService : IDataAccessService
    {
        List<EmployeeInfo> employees;

        public LocalDataService()
        {
            employees = new List<EmployeeInfo>();
        }

        public ObservableCollection<EmployeeInfo> GetEmployees()
        {
            ObservableCollection<EmployeeInfo> Employees = new ObservableCollection<EmployeeInfo>();
            foreach (var item in employees)
            {
                Employees.Add(item);
            }
            return Employees;
        }
        public int CreateEmployee(EmployeeInfo Emp)
        {
            employees.Add(new EmployeeInfo()
            { 
                EmpNo = Emp.EmpNo, 
                EmpName = Emp.EmpName,
                Salary = Emp.Salary,
                DeptName = Emp.DeptName,
                Designation = Emp.Designation
            });
            return Emp.EmpNo;
        }

        public EmployeeInfo GetEmpoyee(int EmpId)
        {
            return employees.FirstOrDefault(e => e.EmpNo == EmpId);
        }
    }
}
