using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using EmployeeManagementLibrary.Model;

namespace EmployeeManagementLibrary.Queries
{
    public record GetEmployeeListQuery() : IRequest<List<EmployeeModel>>;
}
