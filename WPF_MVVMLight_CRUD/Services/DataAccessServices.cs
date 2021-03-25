using System.Collections.ObjectModel;
using System.Linq;
using WPF_MVVMLight_CRUD.Model;

namespace WPF_MVVMLight_CRUD.Services
{
    /// <summary>
    /// Class implementing IDataAccessService interface and implementing
    /// its methods by making call to the Entities using CompanyEntities object
    /// </summary>
    public class DataAccessService : IDataAccessService
    {
        CompanyEntities context;
        public DataAccessService()
        {
            context = new CompanyEntities();
        }
        public ObservableCollection<EmployeeInfo> GetEmployees()
        {
            ObservableCollection<EmployeeInfo> Employees = new ObservableCollection<EmployeeInfo>() ;
            foreach (var item in context.EmployeeInfoes)
            {
                Employees.Add(item);
            }
            return Employees;
        }

        public int CreateEmployee(EmployeeInfo Emp)
        {
            context.EmployeeInfoes.Add(Emp);
            context.SaveChanges();
            return Emp.EmpNo;
        }

        public EmployeeInfo GetEmpoyee(int EmpId)
        {
            return context.EmployeeInfoes.FirstOrDefault(e => e.EmpNo == EmpId);
        }
    }
}
