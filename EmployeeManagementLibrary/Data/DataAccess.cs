using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagementLibrary.Model;

namespace EmployeeManagementLibrary
{
    public class DataAccess : IDataAccess
    {
        private List<EmployeeModel> _employees = new();

        public DataAccess()
        {
            _employees.Add(new EmployeeModel { ID = 1, FirstName = "Chris", LastName = "Evans" });
            _employees.Add(new EmployeeModel { ID = 2, FirstName = "Chuck", LastName = "Norris" });
            _employees.Add(new EmployeeModel { ID = 3, FirstName = "Christiane", LastName = "Bale" });
        }

        public List<EmployeeModel> GetEmployees()
        {
            return _employees;
        }

        public EmployeeModel AddEmployee(string FirstNamem, string LastName)
        {
            EmployeeModel employeeModel = new() { FirstName = FirstNamem, LastName = LastName };
            employeeModel.ID = _employees.Max(x => x.ID) + 1;
            return employeeModel;
        }
    }
}
