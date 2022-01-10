using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagementLibrary.Model;

namespace EmployeeManagementLibrary
{
    public interface IDataAccess
    {
        List<EmployeeModel> GetEmployees();

        EmployeeModel AddEmployee(string FirstNamem, string LastName);

    }
}
