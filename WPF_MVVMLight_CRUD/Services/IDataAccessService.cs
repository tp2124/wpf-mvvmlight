﻿using System.Collections.ObjectModel;
using WPF_MVVMLight_CRUD.Model;


namespace WPF_MVVMLight_CRUD.Services
{

    /// <summary>
    /// The Interface defining methods for Create Employee and Read All Employees  
    /// </summary>
    public interface IDataAccessService
    {
        ObservableCollection<EmployeeInfo> GetEmployees();
        int CreateEmployee(EmployeeInfo Emp);

        EmployeeInfo GetEmpoyee(int EmpId);
    }
}
